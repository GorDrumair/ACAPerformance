using System;

namespace ProductDescriptionFallback;

class Program
{
    static void Main()
    {
        Console.Write("Enter product name: ");
        string? productName = Console.ReadLine();
        Console.Write("Enter description: ");
        string? productDescription = Console.ReadLine();

        Console.WriteLine($"\nProduct: {productName}");
        Console.WriteLine($"Description: {productDescription ?? "No description available"}");
    }
}