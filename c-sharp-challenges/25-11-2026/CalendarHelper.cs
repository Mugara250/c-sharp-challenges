namespace c_sharp_challenges._25_11_2026;

public static class CalendarHelper
{
    public static int GetDaysInMonth(int month, int year)
    {
        if (month < 1 || month > 12) throw new ArgumentOutOfRangeException();
        if (year < 1) throw new ArgumentOutOfRangeException();

        switch (month)
        {
            case 4:
                return 30;
            case 6:
                return 30;
            case 9:
                return 30;
            case 11:
                return 30;
            case 2:
                if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                {
                    return 29;
                }

                return 28;
            default:
                return 31;
        }
    }
}

/*1. The month must be between `1` and `12`, inclusive. Otherwise, throw `ArgumentOutOfRangeException`.
2. The year must be greater than or equal to `1`. Otherwise, throw `ArgumentOutOfRangeException`.
3. February has 28 days in a normal year and 29 days in a leap year.
4. April, June, September, and November have 30 days. All other months have 31 days.
5. Use the Gregorian leap-year rules:
- A year divisible by 400 is a leap year.
- A year divisible by 100 but not 400 is not a leap year.
- Otherwise, a year divisible by 4 is a leap year.

**Restriction:** Do not use `DateTime.DaysInMonth()` or `DateTime.IsLeapYear()`. Implement the logic yourself.*/