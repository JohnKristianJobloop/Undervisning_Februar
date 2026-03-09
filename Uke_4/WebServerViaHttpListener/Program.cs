// See https://aka.ms/new-console-template for more information
using System.Net;
using WebServerViaHttpListener.Services;

Console.WriteLine("Hello, World!");
var listener = new HttpListener();
listener.Prefixes.Add("http://localhost:9002/");
var server = new WebServer(listener);
server.Start();
Console.WriteLine("Press any button to stop....");
Console.ReadLine();
await server.Stop();