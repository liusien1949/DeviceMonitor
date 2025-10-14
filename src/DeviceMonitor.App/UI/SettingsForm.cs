using System;
using System.Windows.Forms;
using DeviceMonitor.App.Processing;

namespace DeviceMonitor.App.UI
{
    public partial class SettingsForm : Form
    {
        private readonly AlarmService _alarmService;

        public SettingsForm(AlarmService alarmService)
        {
            InitializeComponent();
            _alarmService = alarmService;

            LowThresholdNumeric.Value = (decimal)alarmService.LowThreshold;
            HighThresholdNumeric.Value = (decimal)alarmService.HighThreshold;
            AlarmEnabledCheckbox.Checked = alarmService.IsEnabled;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (LowThresholdNumeric.Value >= HighThresholdNumeric.Value)
            {
                MessageBox.Show("Low threshold must be less than high threshold.");
                return;
            }

            _alarmService.Configure((float)LowThresholdNumeric.Value, (float)HighThresholdNumeric.Value, AlarmEnabledCheckbox.Checked);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
