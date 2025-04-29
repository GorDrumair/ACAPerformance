using System;

namespace SwapTwoLettersGame;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a word: ");
        string? input = Console.ReadLine();
        if (string.IsNullOrEmpty(input) || input.Length == 3)
        {
            Console.WriteLine("No input provided. Exiting.\nPress any key to exit.");
            Console.ReadKey(true);
            return;
        }

        char[] charArray = input.ToCharArray();
        char temp = charArray[0];
        charArray[0] = charArray[3];
        charArray[3] = temp;

        string swappedString = new string(charArray);
        Console.WriteLine($"Swapped word: {swappedString}");
        Console.WriteLine("\nPress any key to exit.");
        Console.ReadKey(true);
    }
}