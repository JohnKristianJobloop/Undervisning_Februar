using System;
using System.Net;
using System.Text;

namespace WebServerViaHttpListener.Services;

public class WebServer(HttpListener listener)
{
    private HttpListener _listener = listener;
    private string _rootFolder = "./wwwroot";
    private List<Task> _tasks = [];

    public async Task Start()
    {
        _listener.Start();

        while (true)
        {
            try
            {
                var context = await _listener.GetContextAsync();

                if (context.Request.HttpMethod == "GET") _tasks.Add(ProcessGetRequestAsync(context));
            } catch (HttpListenerException){break;}
        }
    }

    public async Task Stop()
    {
        await Task.WhenAll(_tasks);
        _listener.Stop();
    }

    private async Task ProcessGetRequestAsync(HttpListenerContext context)
    {
        try
        {
            var fileName = context.Request.RawUrl!.TrimStart('/');
            var filePath = Path.Combine(_rootFolder, fileName!);

            byte[] responseMessage;

            if (!File.Exists(filePath))
            {
                responseMessage = Encoding.UTF8.GetBytes($"Sorry, {fileName} doesn't exist");
                context.Response.StatusCode = (int)HttpStatusCode.NotFound;
            } else
            {
                responseMessage = await File.ReadAllBytesAsync(filePath);
                if (Path.GetExtension(fileName) == "jpg")
                {
                    context.Response.ContentType = "image/jpeg";
                }
                context.Response.StatusCode = (int)HttpStatusCode.OK;
            }
            context.Response.ContentLength64 = responseMessage.Length;

            using var outputStream = context.Response.OutputStream;
            await outputStream.WriteAsync(responseMessage);
        } catch (ArgumentException ex)
        {
            Console.WriteLine($"Errors reading filepaths: {ex.Message}");
        } catch (OperationCanceledException opEx)
        {
            Console.WriteLine($"Stream reading was cancelled: {opEx.Message}");
        }
    }

}
