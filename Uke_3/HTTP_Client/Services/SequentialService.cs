using System;
using System.Diagnostics;

namespace HTTP_Client.Services;

public class SequentialService(HttpClient client) : BaseService(client)
{
    public async Task SendSequentialRequestsWithStopwatch(IEnumerable<string> endpoints)
    {
        var stopwatch = Stopwatch.StartNew();
        foreach (var endpoint in endpoints)
        {
            await FetchDataFromEndpoint(endpoint);
        }
        stopwatch.Stop();
        Console.WriteLine($"Sequential Operation took {stopwatch.ElapsedMilliseconds}ms to complete");
    }

}
