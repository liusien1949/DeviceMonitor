using System;

namespace DeviceMonitor.App.Processing
{
    public class AlarmService
    {
        public event EventHandler<AlarmEventArgs>? AlarmChanged;

        public float LowThreshold { get; private set; } = 0;

        public float HighThreshold { get; private set; } = 50;

        public bool IsEnabled { get; private set; } = true;

        public void Configure(float lowThreshold, float highThreshold, bool isEnabled)
        {
            LowThreshold = lowThreshold;
            HighThreshold = highThreshold;
            IsEnabled = isEnabled;
        }

        internal void Check(float temperature)
        {
            if (!IsEnabled)
            {
                return;
            }

            if (temperature > HighThreshold)
            {
                AlarmChanged?.Invoke(this, new AlarmEventArgs(HighThreshold, temperature, true, true));
            }
            else if (temperature < LowThreshold)
            {
                AlarmChanged?.Invoke(this, new AlarmEventArgs(LowThreshold, temperature, true, false));
            }
            else
            {
                AlarmChanged?.Invoke(this, new AlarmEventArgs(temperature, temperature, false, false));
            }
        }
    }
}
