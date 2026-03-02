using System;
using Async_programmering.Models;

namespace Async_programmering.Services;

public static class CountWithAsyncAwait
{
    public static List<Task> CountAsync(IEnumerable<Counter> counters)
    {
        List<Task> tasks = [];

        foreach(var counter in counters)
        {
            tasks.Add(DoWorkAsync(counter));
        }
        return tasks;
    }

    private static async Task DoWorkAsync(Counter counter)
    {
        Console.WriteLine($"Counter {counter.Name} started on thread....");

        for (var i = 0; i < counter.MaxCount; i++)
        {
            await Task.Delay(counter.DelayInMs);
            Console.WriteLine($"Counted {i+1} times");
        }
        Console.WriteLine($"Counter {counter.Name} done..");
    }
}
