using System;

namespace CharacterPicker;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a word: ");
        string? input = Console.ReadLine();
        if (string.IsNullOrEmpty(input) || input.Length < 6)
        {
            Console.WriteLine("No input provided. Exiting.\nPress any key to exit.");
            Console.ReadKey(true);
            return;
        }

        Console.WriteLine($"Characters picked from the word: {input[1]}{input[3]}{input[5]}");
        Console.WriteLine("\nPress any key to exit.");
        Console.ReadKey(true);
    }
}