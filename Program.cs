using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
using Microsoft.VisualBasic;

//Console.WriteLine("Hello, World!");

int myInt = 10;
string text = "thisIsAnExample";
double numeral = 10.25;
char e = '/';

Console.WriteLine("Hello World!" + myInt, text, numeral, e);

// Integer array for-løkke
int[] intArray = new int[5]; // Integer array for 5 integers
{
    for (int i = 0; i < intArray.Length; i++)
    {
        intArray[i] = i; // Index starter fra 0, istedet for i + 1; som vil starte fra 1
        Console.WriteLine(" " + intArray[i]);
    }
}

// String array foreach-løkke
string[] bucketType = { "Bucket-1", "Bucket-2", "Bucket-3" };
{
    foreach (string i in bucketType)
    {
        Console.WriteLine(i); // Skriver ut alle bucket types i konsollen
    }
}

List<string> firstList = new List<string>();
{
    foreach (string i in firstList) ;


    firstList.Add("myString");
    firstList.Add("yourString");
    firstList.Add("hisString");
    firstList.Add("herString");

    if (firstList.Contains("myString"))
    {
        Console.WriteLine(" " + "List contains myString");
    }
    else
    {
        Console.WriteLine(" " + "List does not contain myString");
    }
}

Dictionary<int, string> myDictionary = new Dictionary<int, string>();
{
    myDictionary.Add(0, "str0");
    myDictionary.Add(100, "str1");

    foreach (var kvp in myDictionary)
    {
        Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}"); // Skriver ut integer og string i konsollen
    }
}

int a = 1;
int b = 2;

int sum = a + b;
Console.WriteLine("The sum is equal to" + " " + sum); // Setter sammen int a + int b og gir en totalsum i konsollen
Console.ReadLine();

string welcomeUser = "User";
string welcomeMessage = $"Hello" + " " + welcomeUser + "!";

Console.WriteLine(welcomeMessage); // Setter sammen stringene 1 + 2 og skriver det i en setning "Hello User! i konsollen"