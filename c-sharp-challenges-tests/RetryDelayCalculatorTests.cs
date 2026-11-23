namespace c_sharp_challenges_tests;

public class RetryDelayCalculatorTests
{
    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(3)]
    [InlineData(4)]
    [InlineData(5)]
    public void Retry_With_Delay_Attempts_1_To_5(int attempt)
    {
        if (attempt >= 4)
        {
            Assert.Equal(TimeSpan.FromSeconds(2 ^ 3), RetryDelayCalculator.GetDelay(attempt));
        } else if (attempt == 3)
        {
            Assert.Equal(TimeSpan.FromSeconds(2 ^ 2), RetryDelayCalculator.GetDelay(attempt));
        } else if (attempt == 2)
        {
            Assert.Equal(TimeSpan.FromSeconds(2), RetryDelayCalculator.GetDelay(attempt));
        }
        else
        {
            Assert.Equal(TimeSpan.FromSeconds(1), RetryDelayCalculator.GetDelay(1));
        }
    }

    [Fact]
    public void Invalid_Attempt_Number_Throw()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => RetryDelayCalculator.GetDelay(0));
    }
}