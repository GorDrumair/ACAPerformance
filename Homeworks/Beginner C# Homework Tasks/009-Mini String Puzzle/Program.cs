using System;

namespace AlphabeticalDifference;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter first lettr: ");
        string? firstLetter = Console.ReadLine();
        Console.Write("Enter second letter: ");
        string? secondLetter = Console.ReadLine();
        if (string.IsNullOrEmpty(firstLetter) || string.IsNullOrEmpty(secondLetter))
        {
            Console.WriteLine("No input provided. Exiting.\nPress any key to exit.");
            Console.ReadKey(true);
            return;
        }

        int difference = Math.Abs(firstLetter[0] - secondLetter[0]);

        Console.WriteLine($"{firstLetter[0]}: {(sbyte)firstLetter[0]}, {secondLetter[0]}: {(sbyte)secondLetter[0]}");
        Console.WriteLine($"Alphabetical difference: {difference}");
        Console.WriteLine("\nPress any key to exit.");
        Console.ReadKey(true);
    }
}