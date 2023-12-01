// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


var input = File.ReadAllLines("input.txt");

int result = 0;

foreach(string s in input)
{
    result += Traitement.GetNumbers(s);
}

Console.WriteLine(result);