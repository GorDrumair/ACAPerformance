using System;

namespace TimeInterval;

class Program
{
    static void Main(string[] args)
    {
        DateTime start = new DateTime(2025, 06, 14, 5, 30, 0);
        DateTime end = new DateTime(2025, 06, 14, 20, 30, 0);

        TimeInterval interval = new TimeInterval(start, end);
        Console.WriteLine($"Start Time: {interval.startTime}");
        Console.WriteLine($"End Time: {interval.endTime}");
        Console.WriteLine($"Duration: {interval.GetDuration()}");
    }
}

struct TimeInterval
{
    public DateTime startTime;
    public DateTime endTime;

    public TimeInterval(DateTime start, DateTime end)
    {
        startTime = start;
        endTime = end;
    }

    public TimeSpan GetDuration()
    {
        return endTime - startTime;
    }
}