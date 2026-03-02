
using System.Diagnostics;
using Async_programmering.Models;
using Async_programmering.Services;

/*var thread = new Thread(HeavyWorkService.DoingWorkInALoop);
thread.Start();

thread.Join();
HeavyWorkService.DoingWorkInALoop();*/

List<Counter> counters = [
    new ("Counter 1", 10, 100),
    new ("Counter 2", 5, 250),
    new ("Counter 3", 3, 400)
];

var threadStopWatch = Stopwatch.StartNew();
var threads = CountOnThreads.CountingOnThreads(counters);

foreach(var thread in threads) thread.Join();
threadStopWatch.Stop();

var taskStopWatch = Stopwatch.StartNew();
await Task.WhenAll(CountWithAsyncAwait.CountAsync(counters));
taskStopWatch.Stop();

Console.WriteLine($"Threads took {threadStopWatch.ElapsedMilliseconds}ms to complete");

Console.WriteLine($"Tasks took {taskStopWatch.ElapsedMilliseconds}ms to complete");
