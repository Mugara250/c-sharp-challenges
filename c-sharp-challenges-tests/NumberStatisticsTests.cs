using c_sharp_challenges._26_11_2026;

namespace c_sharp_challenges_tests;

using System;
using Xunit;

public class NumberStatisticsTests
{
    [Fact]
    public void FindSecondLargest_WithDifferentNumbers_ReturnsSecondLargest()
    {
        int[] numbers = { 10, 4, 8, 2 };

        var result = NumberStatistics.FindSecondLargest(numbers);

        Assert.Equal(8, result);
    }

    [Fact]
    public void FindSecondLargest_WithDuplicates_ReturnsSecondLargestDistinctNumber()
    {
        int[] numbers = { 10, 10, 9, 9, 8 };

        var result = NumberStatistics.FindSecondLargest(numbers);

        Assert.Equal(9, result);
    }

    [Fact]
    public void FindSecondLargest_WithNegativeNumbers_ReturnsCorrectResult()
    {
        int[] numbers = { -5, -2, -9, -4 };

        var result = NumberStatistics.FindSecondLargest(numbers);

        Assert.Equal(-4, result);
    }

    [Fact]
    public void FindSecondLargest_WithInsufficientDistinctNumbers_ReturnsNull()
    {
        Assert.Null(NumberStatistics.FindSecondLargest(Array.Empty<int>()));
        Assert.Null(NumberStatistics.FindSecondLargest(new[] { 7, 7, 7 }));
    }

    [Fact]
    public void FindSecondLargest_WithNullArray_ThrowsArgumentNullException()
    {
        Assert.Throws<ArgumentNullException>(
            () => NumberStatistics.FindSecondLargest(null!)
        );
    }
}