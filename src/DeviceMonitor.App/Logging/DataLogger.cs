using System;
using System.Globalization;
using System.IO;
using DeviceMonitor.App.Models;

namespace DeviceMonitor.App.Logging
{
    public sealed class DataLogger : IDisposable
    {
        private StreamWriter? _writer;

        public bool IsLogging => _writer != null;

        public void StartLogging(string filePath)
        {
            StopLogging();
            var directory = Path.GetDirectoryName(filePath);
            if (string.IsNullOrEmpty(directory))
            {
                directory = ".";
            }

            Directory.CreateDirectory(directory);
            _writer = new StreamWriter(File.Open(filePath, FileMode.Create, FileAccess.Write, FileShare.Read))
            {
                AutoFlush = true
            };
            _writer.WriteLine("时间戳,温度值(℃)");
        }

        public void StopLogging()
        {
            _writer?.Dispose();
            _writer = null;
        }

        public void LogData(TemperatureReading reading)
        {
            if (!IsLogging)
            {
                return;
            }

            var line = string.Format(CultureInfo.InvariantCulture, "{0:yyyy-MM-dd HH:mm:ss},{1:F2}", reading.Timestamp, reading.Temperature);
            _writer!.WriteLine(line);
        }

        public void Dispose()
        {
            StopLogging();
        }
    }
}
