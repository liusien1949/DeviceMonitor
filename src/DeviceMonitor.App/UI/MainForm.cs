using System;
using System.ComponentModel;
using System.Media;
using System.Windows.Forms;
using DeviceMonitor.App.Communication;
using DeviceMonitor.App.Logging;
using DeviceMonitor.App.Models;
using DeviceMonitor.App.Processing;

namespace DeviceMonitor.App.UI
{
    public partial class MainForm : Form
    {
        private readonly SerialCommunicator _communicator;
        private readonly DataLogger _dataLogger;
        private readonly DataProcessor _dataProcessor;
        private readonly BindingList<TemperatureReading> _recentReadings = new();

        public MainForm()
        {
            InitializeComponent();

            _communicator = new SerialCommunicator();
            _dataLogger = new DataLogger();
            _dataProcessor = new DataProcessor(new AlarmService());

            PortsComboBox.DataSource = _communicator.ListAvailablePorts();
            BaudRateComboBox.SelectedIndex = 0;

            TemperatureGrid.DataSource = _recentReadings;

            _communicator.DataReceived += OnCommunicatorDataReceived;
            _dataProcessor.TemperatureParsed += OnTemperatureParsed;
            _dataProcessor.AlarmTriggered += OnAlarmTriggered;
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            if (_communicator.IsConnected)
            {
                _communicator.Disconnect();
                ConnectionStatusLabel.Text = "Disconnected";
                ConnectButton.Text = "Connect";
                return;
            }

            if (PortsComboBox.SelectedItem is not string portName)
            {
                MessageBox.Show("Please select a serial port before connecting.");
                return;
            }

            var baudRate = int.Parse(BaudRateComboBox.SelectedItem?.ToString() ?? "9600");
            try
            {
                _communicator.Connect(portName, baudRate);
                ConnectionStatusLabel.Text = $"Connected to {portName}";
                ConnectButton.Text = "Disconnect";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to connect: {ex.Message}");
            }
        }

        private void StartLoggingButton_Click(object sender, EventArgs e)
        {
            using var dialog = new SaveFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv",
                FileName = $"TemperatureLog_{DateTime.Now:yyyyMMdd_HHmmss}.csv"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _dataLogger.StartLogging(dialog.FileName);
                    StartLoggingButton.Enabled = false;
                    StopLoggingButton.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Unable to start logging: {ex.Message}");
                }
            }
        }

        private void StopLoggingButton_Click(object sender, EventArgs e)
        {
            _dataLogger.StopLogging();
            StartLoggingButton.Enabled = true;
            StopLoggingButton.Enabled = false;
        }

        private void OnCommunicatorDataReceived(object? sender, string data)
        {
            BeginInvoke(() => _dataProcessor.ParseData(data));
        }

        private void OnTemperatureParsed(object? sender, TemperatureReading reading)
        {
            CurrentTemperatureLabel.Text = $"{reading.Temperature:F1} ℃";
            LastUpdatedLabel.Text = reading.Timestamp.ToString("yyyy-MM-dd HH:mm:ss");

            if (_recentReadings.Count > 50)
            {
                _recentReadings.RemoveAt(0);
            }

            _recentReadings.Add(reading);
            var series = TemperatureChart.Series[0];
            series.Points.AddXY(reading.Timestamp, reading.Temperature);
            while (series.Points.Count > 50)
            {
                series.Points.RemoveAt(0);
            }

            if (_dataLogger.IsLogging)
            {
                _dataLogger.LogData(reading);
            }
        }

        private void OnAlarmTriggered(object? sender, AlarmEventArgs e)
        {
            if (!e.IsAlarm)
            {
                AlarmStatusLabel.Text = "Alarm: Normal";
                AlarmStatusLabel.ForeColor = System.Drawing.Color.ForestGreen;
                return;
            }

            AlarmStatusLabel.Text = e.IsHighAlarm ? "Alarm: Temperature High" : "Alarm: Temperature Low";
            AlarmStatusLabel.ForeColor = e.IsHighAlarm ? System.Drawing.Color.Red : System.Drawing.Color.DeepSkyBlue;
            SystemSounds.Exclamation.Play();
        }

        private void AlarmSettingsButton_Click(object sender, EventArgs e)
        {
            using var dialog = new SettingsForm(_dataProcessor.AlarmService);
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                if (!_dataProcessor.AlarmService.IsEnabled)
                {
                    AlarmStatusLabel.Text = "Alarm: Disabled";
                    AlarmStatusLabel.ForeColor = System.Drawing.Color.Gray;
                }
                else
                {
                    AlarmStatusLabel.Text = "Alarm: Normal";
                    AlarmStatusLabel.ForeColor = System.Drawing.Color.ForestGreen;
                }
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _communicator.Dispose();
            _dataLogger.Dispose();
            base.OnFormClosed(e);
        }
    }
}
