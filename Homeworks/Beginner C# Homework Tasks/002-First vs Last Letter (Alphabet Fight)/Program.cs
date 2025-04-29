using System;

namespace FirstVsLastLetter;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a word: ");
        string? input = Console.ReadLine();
        if (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("No input provided. Exiting.\nPress any key to exit.");
            Console.ReadKey(true);
            return;
        }

        char firstLetter = input[0];
        char lastLetter = input[input.Length - 1];

        if (((sbyte)firstLetter) < ((sbyte)lastLetter))
        {
            Console.WriteLine($"Between {firstLetter} and {lastLetter}, {firstLetter} wins!");
        }
        else if (((sbyte)firstLetter) > ((sbyte)lastLetter))
        {
            Console.WriteLine($"Between {firstLetter} and {lastLetter}, {lastLetter} wins!");
        }
        else
        {
            Console.WriteLine($"It's the same letter: {firstLetter}!");
        }

        Console.WriteLine("\nPress any key to exit.");
        Console.ReadKey(true);
    }
}