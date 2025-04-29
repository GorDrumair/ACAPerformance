using System;

namespace FunnyNameGenerator;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a your favorite color: ");
        string? colorInput = Console.ReadLine();
        Console.Write("Enter a your favorite animal: ");
        string? animalInput = Console.ReadLine();

        if (string.IsNullOrEmpty(colorInput) || string.IsNullOrEmpty(animalInput))
        {
            Console.WriteLine("No input provided. Exiting.\nPress any key to exit.");
            Console.ReadKey(true);
            return;
        }

        Console.WriteLine($"Your funny name is: {colorInput} {animalInput}!");

        Console.WriteLine("\nPress any key to exit.");
        Console.ReadKey(true);
    }
}