using System;

namespace LetterDistanceChecker;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter first letter: ");
        string? firstLetter = Console.ReadLine();
        Console.Write("Enter second letter: ");
        string? secondLetter = Console.ReadLine();

        if (string.IsNullOrEmpty(firstLetter) || string.IsNullOrEmpty(secondLetter))
        {
            Console.WriteLine("No input provided. Exiting.\nPress any key to exit.");
            Console.ReadKey(true);
            return;
        }

        int distance = Math.Abs(firstLetter[0] - secondLetter[0]);
        Console.WriteLine($"Distance between the first and third letters: {distance}");
        Console.WriteLine("\nPress any key to exit.");
        Console.ReadKey(true);
    }
}