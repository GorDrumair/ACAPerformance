using System;

namespace CharactersUpperAndLowerMix;

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

        char[] toUpperArray = new char[input.Length];
        char[] toLowerArray = new char[input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            toUpperArray[i] = char.ToUpper(input[i]);
            toLowerArray[i] = char.ToLower(input[i]);
        }
        
        string outputString = new string(toUpperArray) + new string(toLowerArray);
        Console.WriteLine($"Upper and lower case word: {outputString}");
        Console.WriteLine("\nPress any key to exit.");
        Console.ReadKey(true);
    }
}