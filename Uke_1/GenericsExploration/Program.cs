// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


int[] arr = [1,2,3,4,5];

for (var i = 0f; i < 100; i+=0.3f)
{
    Console.WriteLine(i.GetHashCode());
    Console.WriteLine(arr[i.GetHashCode() % arr.Length]);
}

