using System;

namespace HelloApplication;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hi, what's your name?");
        string? name = Console.ReadLine();
        Console.WriteLine($"Hello, {name}! Welcome to the C# world.");
        Console.ReadKey(true);
    }
}