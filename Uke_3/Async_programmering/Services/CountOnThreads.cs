using System;
using Async_programmering.Models;

namespace Async_programmering.Services;

public class CountOnThreads
{
    public static List<Thread> CountingOnThreads(IEnumerable<Counter> counters)
    {
        List<Thread> threads = [];

        foreach (var counter in counters)
        {
            var thread = new Thread(DoCount);
            thread.Start(counter);
            threads.Add(thread);
        }
        return threads;
    }

    private static void DoCount(object? state)
    {
        var counter = (Counter)state!;
        Console.WriteLine($"Counter {counter.Name} started on thread....");

        for (var i = 0; i < counter.MaxCount; i++)
        {
            Thread.Sleep(counter.DelayInMs);
            Console.WriteLine($"Counted {i+1} times");
        }
        Console.WriteLine($"Counter {counter.Name} done..");

    }

}
