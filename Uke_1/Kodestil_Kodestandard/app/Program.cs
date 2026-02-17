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