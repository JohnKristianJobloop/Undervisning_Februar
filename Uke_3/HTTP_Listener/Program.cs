using System.Net;
using System.Text;

var listener = new HttpListener();
listener.Prefixes.Add("http://localhost:9001/");
listener.Start();

var context = await listener.GetContextAsync();
Console.WriteLine(context.Request.HttpMethod);
Console.WriteLine(context.Request.RawUrl);

var responseMessage = $"You asked for: {context.Request.RawUrl}\n";

context.Response.ContentLength64 = Encoding.UTF8.GetByteCount(responseMessage);

context.Response.StatusCode = (int)HttpStatusCode.OK;

using var outputStream = context.Response.OutputStream;

await outputStream.WriteAsync(Encoding.UTF8.GetBytes(responseMessage));

listener.Close();