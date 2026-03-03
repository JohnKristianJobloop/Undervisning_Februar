
using System.Net.Http.Headers;

namespace HTTP_Client.Services;

public class BaseService(HttpClient client)
{
    public async Task FetchDataFromEndpoint(string endpoint)
    {
        try
        {
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var response = await client.GetAsync(endpoint);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            Console.WriteLine($"Received {content} from {endpoint}");
        } catch (HttpRequestException ex)
        {
            Console.WriteLine($"something went wrong when reading from {endpoint}: {ex.Message}");
        }
        
    }
}
