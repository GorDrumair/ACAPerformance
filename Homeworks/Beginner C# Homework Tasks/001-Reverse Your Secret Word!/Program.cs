using System;

namespace ReverseYourSecretWord;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a secret word: ");
        string? input = Console.ReadLine();
        if (string.IsNullOrEmpty(input) || input.Length < 8)
        {
            Console.WriteLine("No input provided. Exiting.\nPress any key to exit.");
            Console.ReadKey(true);
            return;
        }

        char[] reversedArray = new char[input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            reversedArray[i] = input[input.Length - 1 - i];
        }
            
        string reversedString = new string(reversedArray);
        Console.WriteLine($"Secret word: {reversedString}");
        Console.WriteLine("\nPress any key to exit.");
        Console.ReadKey(true);
    }
}