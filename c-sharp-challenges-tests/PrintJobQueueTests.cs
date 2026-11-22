using c_sharp_challenges._19_11_2026;

namespace c_sharp_challenges_tests;

public class PrintJobQueueTests
{
    [Fact]
    public void Processing_Jobs_In_FIFO_Order()
    {
        var printer = new PrintJobQueue();
        printer.AddJob("Report.pdf");
        printer.AddJob("Invoice.pdf");

        var result = printer.ProcessNext();
        Assert.Equal("Report.pdf", result);
    }

    [Fact]
    public void Processing_An_Empty_Queue()
    {
        var printer = new PrintJobQueue();
        var result = printer.ProcessNext();
        Assert.True(result is null);
    }

    [Theory]
    [InlineData("")]
    [InlineData(null)]
    [InlineData(" ")]
    public void Rejecting_An_Invalid_Job_Name(string? jobName)
    {
        var printer = new PrintJobQueue();
        Assert.Throws<ArgumentException>(() => printer.AddJob(jobName));
    }
}

/*- Processing jobs in FIFO order.
- Processing an empty queue.
- Rejecting an invalid job name.*/