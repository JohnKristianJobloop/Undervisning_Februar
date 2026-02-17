using app.Models;

Console.WriteLine("Hello, world!");

int globalInt;

{
    int integer = 10;

    string name = "John";

    float num1 = 0.01f;

    decimal num2 = 0.02m;

    double num3 = 0.03;

    byte someByte = 0x0001;

    char letter = 'A';
    globalInt = 20;
}


//henter datatypen fra høyresiden av deklarasjonstegnet vårt ( = ) og copy paster inn typenavnet inn der var står. 
var myAge = 34;

var myName = "John";


var studentGradesTable = new Dictionary<string, List<int>>()
{
    {"John", [4,4,5,4,6,4,3]}
};

double division = 10 / (double)7;

List<string> names = ["John", "Jørgen"];

List<int> ages = [];


List<int> scores = new List<int>();




var someArray = new int[3]; //[0, 0, 0]
int[] someOtherArray = [3]; // [3]

Dictionary<string, int> nameAndAge = new()
{
    ["John"] = 33,
    ["Arne"] = 42,
    ["Jørgen"] = 30
};

Dictionary<string, int> nameAndAgeOldWay = new()
{
    {"John", 33},
    {"Jørgen", 30}
};

Dictionary<string, int> nameAndAgeAsEmpty = [];


Console.WriteLine(globalInt);


var personA = new Person(123, "John");

var personB = new Person(123, "John");

Console.WriteLine(personA.GetHashCode() == personB.GetHashCode());
Console.WriteLine(personA.GetHashCode());
Console.WriteLine(personB.GetHashCode());

var test = new Test();
Console.WriteLine(test.GetHashCode());

int a = 5;
int b = 5;
Console.WriteLine(a.GetHashCode() == b.GetHashCode());
Console.WriteLine(a.GetHashCode());

public class Test
{
    
}