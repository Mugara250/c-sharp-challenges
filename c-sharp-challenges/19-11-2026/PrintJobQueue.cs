namespace c_sharp_challenges._19_11_2026;

#nullable enable

using System;
using System.Collections.Generic;

public class PrintJobQueue
{
    private readonly Queue<string> _jobs = new();

    public void AddJob(string? jobName)
    {
        if (string.IsNullOrEmpty(jobName) || string.IsNullOrWhiteSpace(jobName)) throw new ArgumentException();
        _jobs.Enqueue(jobName.Trim());
    }

    public string? ProcessNext()
    {
        if (_jobs.Count == 0)   return null;
        var oldestJob = _jobs.Dequeue();
        return oldestJob;
    }

    public int PendingCount => _jobs.Count;
}

/*1. `AddJob` must add a job to the queue. Job names must not be null, empty, or whitespace; otherwise, throw `ArgumentException`.
2. Remove leading and trailing whitespace from valid job names before storing them.
3. `ProcessNext` must return and remove the oldest job (FIFO).
4. If there are no jobs, `ProcessNext` must return `null`.
5. `PendingCount` must always represent the number of jobs waiting to be processed.*/

