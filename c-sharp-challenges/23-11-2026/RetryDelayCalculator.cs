using System;

public static class RetryDelayCalculator
{
    public static TimeSpan GetDelay(int attempt)
    {
        if (attempt == 0 || attempt < 0) throw new ArgumentOutOfRangeException();

        TimeSpan delay;

        if (attempt >= 4)
        {
            delay = TimeSpan.FromSeconds(2 ^ 3);
        } else if (attempt == 3)
        {
            delay = TimeSpan.FromSeconds(2 ^ 2);
        } else if (attempt == 2)
        {
            delay = TimeSpan.FromSeconds(2);
        }
        else
        {
            delay = TimeSpan.FromSeconds(1);
        }

        return delay;
    }
}