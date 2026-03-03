using System;
using System.Diagnostics;

namespace HTTP_Client.Services;

public class ParallellService(HttpClient client) : BaseService(client)
{
    public async Task SendParallellRequestWithStopwatch(IEnumerable<string> endpoints)
    {
        var stopwatch = Stopwatch.StartNew();

        List<Task> tasks = [..endpoints.Select(endpoint => FetchDataFromEndpoint(endpoint))];

        await Task.WhenAll(tasks);
         stopwatch.Stop();

         Console.WriteLine($"Parallell operation took {stopwatch.ElapsedMilliseconds}ms to complete");
    }
}
