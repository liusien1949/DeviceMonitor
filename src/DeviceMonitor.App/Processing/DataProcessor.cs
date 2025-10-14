using System;
using System.Globalization;
using System.Text.RegularExpressions;
using DeviceMonitor.App.Models;

namespace DeviceMonitor.App.Processing
{
    public class DataProcessor
    {
        private static readonly Regex TemperaturePattern = new("^T:(-?\\d+(?:\\.\\d+)?)$", RegexOptions.Compiled | RegexOptions.CultureInvariant);

        public DataProcessor(AlarmService alarmService)
        {
            AlarmService = alarmService;
            AlarmService.AlarmChanged += (_, args) => AlarmTriggered?.Invoke(this, args);
        }

        public AlarmService AlarmService { get; }

        public event EventHandler<TemperatureReading>? TemperatureParsed;

        public event EventHandler<AlarmEventArgs>? AlarmTriggered;

        public void ParseData(string rawData)
        {
            var cleaned = rawData.Trim();
            if (string.IsNullOrEmpty(cleaned))
            {
                return;
            }

            var match = TemperaturePattern.Match(cleaned);
            if (!match.Success)
            {
                return;
            }

            if (!float.TryParse(match.Groups[1].Value, NumberStyles.Float, CultureInfo.InvariantCulture, out var temperature))
            {
                return;
            }

            var reading = new TemperatureReading(DateTime.Now, temperature);
            TemperatureParsed?.Invoke(this, reading);
            AlarmService.Check(temperature);
        }
    }
}
