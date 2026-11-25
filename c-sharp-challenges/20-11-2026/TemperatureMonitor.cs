namespace c_sharp_challenges._20_11_2026;

#nullable enable

using System;

public class TemperatureMonitor
{
    private readonly int _threshold;

    public event Action<int>? ThresholdExceeded;

    public TemperatureMonitor(int threshold)
    {
        _threshold = threshold;
    }

    public void RecordTemperature(int temperature)
    {
        if (temperature > _threshold) ThresholdExceeded?.Invoke(temperature);
    }
}