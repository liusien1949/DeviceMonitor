using System;

namespace DeviceMonitor.App.Processing
{
    public class AlarmEventArgs : EventArgs
    {
        public AlarmEventArgs(float threshold, float actual, bool isAlarm, bool isHighAlarm)
        {
            Threshold = threshold;
            Actual = actual;
            IsAlarm = isAlarm;
            IsHighAlarm = isHighAlarm;
        }

        public float Threshold { get; }

        public float Actual { get; }

        public bool IsAlarm { get; }

        public bool IsHighAlarm { get; }
    }
}
