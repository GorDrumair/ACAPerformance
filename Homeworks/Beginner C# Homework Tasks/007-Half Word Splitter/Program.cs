using System;

namespace HalfWordSplitter;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a word: ");
        string? input = Console.ReadLine();
        if (string.IsNullOrEmpty(input) || input.Length % 2 != 0)
        {
            Console.WriteLine("No input provided. Exiting.\nPress any key to exit.");
            Console.ReadKey(true);
            return;
        }

        int halfLength = input.Length / 2;
        string firstHalf = input.Substring(0, halfLength);
        string secondHalf = input.Substring(halfLength);

        Console.WriteLine($"First half: {firstHalf}");
        Console.WriteLine($"Second half: {secondHalf}");
        Console.WriteLine("\nPress any key to exit.");
        Console.ReadKey(true);
    }
}