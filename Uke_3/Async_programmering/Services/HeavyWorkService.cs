using System;

namespace Async_programmering.Services;

public static class HeavyWorkService
{
    public static void DoSomeHeavyWork()
    {
        Console.WriteLine("Doing some heavy lifting");
        //Vi simulerer å hente resurser fra utsiden av programmet vårt. 
        Thread.Sleep(1000);
        Console.WriteLine("Job done...");
    }

    public static void DoingWorkInALoop()
    {
        Console.WriteLine("Starting...");
        for(var i = 0; i < 100; i++)
        {
            Console.WriteLine($"Processing {i}...");
        }
        Console.WriteLine("Job done...");
    }
}
