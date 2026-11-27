using c_sharp_challenges._25_11_2026;

namespace c_sharp_challenges_tests;

public class CalendarHelperTests
{
    [Theory]
    [InlineData(1, 2025)]
    [InlineData(4, 2025)]
    [InlineData(2, 2025)]
    [InlineData(2, 2024)]
    [InlineData(2, 1900)]
    public void Get_Days_From_Valid_Months_And_Years(int month, int year)
    {
        if (month == 1) Assert.Equal(31, CalendarHelper.GetDaysInMonth(month, year));
        if (month == 4) Assert.Equal(30, CalendarHelper.GetDaysInMonth(month, year));
        if (month == 2 && year == 2025) Assert.Equal(28, CalendarHelper.GetDaysInMonth(month, year));
        if (month == 2 && year == 2024) Assert.Equal(29, CalendarHelper.GetDaysInMonth(month, year));
        if (month == 2 && year == 1900) Assert.Equal(28, CalendarHelper.GetDaysInMonth(month, year));
    }

    [Fact]
    public void Leap_Year_Exceptions()
    {
        Assert.Equal(29, CalendarHelper.GetDaysInMonth(2, 2000));
    }
    
    [Theory]
    [InlineData(0, 2000)]
    [InlineData(13, 2000)]
    [InlineData(2, 0)]
    public void Invalid_Month_And_Year_Rejected(int month, int year)
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => CalendarHelper.GetDaysInMonth(month, year));
    }
}