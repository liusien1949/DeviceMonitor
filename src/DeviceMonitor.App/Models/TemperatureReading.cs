using System;

namespace DeviceMonitor.App.Models
{
    public record struct TemperatureReading(DateTime Timestamp, float Temperature);
}
