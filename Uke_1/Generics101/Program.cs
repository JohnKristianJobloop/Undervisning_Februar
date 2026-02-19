// See https://aka.ms/new-console-template for more information
using Generics101.Models;

Console.WriteLine("Hello, World!");

var intStorage = new GenericStorage<int>();

intStorage.Set(10);

intStorage.Display();

var stringStorage = new GenericStorage<string>();

stringStorage.Set("John");

stringStorage.Display();

var result = GenericCalculator<int>.Add(1, 1);

var doubleResult = GenericCalculator<double>.Add(0.5, 0.234);

