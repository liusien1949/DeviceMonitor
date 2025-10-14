using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;

namespace DeviceMonitor.App.Communication
{
    public sealed class SerialCommunicator : IDisposable
    {
        private SerialPort? _serialPort;

        public bool IsConnected => _serialPort?.IsOpen == true;

        public event EventHandler<string>? DataReceived;

        public IReadOnlyList<string> ListAvailablePorts()
        {
            var ports = SerialPort.GetPortNames();
            Array.Sort(ports, StringComparer.OrdinalIgnoreCase);
            return ports;
        }

        public void Connect(string portName, int baudRate)
        {
            Disconnect();

            _serialPort = new SerialPort(portName, baudRate)
            {
                NewLine = "\r\n",
                ReadTimeout = 1000
            };

            _serialPort.DataReceived += HandleDataReceived;
            _serialPort.Open();
        }

        public void Disconnect()
        {
            if (_serialPort == null)
            {
                return;
            }

            _serialPort.DataReceived -= HandleDataReceived;
            if (_serialPort.IsOpen)
            {
                _serialPort.Close();
            }

            _serialPort.Dispose();
            _serialPort = null;
        }

        public void SendData(string data)
        {
            if (!IsConnected)
            {
                throw new InvalidOperationException("Serial port is not connected.");
            }

            _serialPort!.WriteLine(data);
        }

        private void HandleDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (sender is not SerialPort port)
            {
                return;
            }

            try
            {
                var line = port.ReadLine();
                DataReceived?.Invoke(this, line);
            }
            catch (TimeoutException)
            {
                // Ignore timeouts and wait for the next packet.
            }
            catch (IOException)
            {
                // Ignore transient I/O failures that may occur when disconnecting the cable.
            }
            catch (InvalidOperationException)
            {
                // Port closed while reading, safe to ignore.
            }
        }

        public void Dispose()
        {
            Disconnect();
        }
    }
}
