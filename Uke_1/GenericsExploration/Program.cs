// See https://aka.ms/new-console-template for more information
using GenericsExploration.Models;

Console.WriteLine("Hello, World!");

var notFuntioningDictionary = new KodehodeDictionary<string, int>(200);

notFuntioningDictionary.Add("John", 34);

var result = notFuntioningDictionary.TryGetValue("John", out var val);

Console.WriteLine($"{result}: {val}");

notFuntioningDictionary.Add("John", 42);

result = notFuntioningDictionary.TryGetValue("John", out val);

Console.WriteLine($"{result}: {val}");

