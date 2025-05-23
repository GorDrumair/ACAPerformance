using System;

namespace OptionalDiscountCode;

class Program
{
    static void Main()
    {
        Console.Write("Enter disount code: ");
        string? code = Console.ReadLine();
        string output = code == "" || code is null ? "NO CODE ENTERED" : code;

        Console.WriteLine($"Discount applied: {output}");
    }
}