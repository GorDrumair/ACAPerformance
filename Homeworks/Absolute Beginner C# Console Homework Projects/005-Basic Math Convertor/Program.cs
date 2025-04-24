using System;

namespace BasicMathConvertor;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hours to Minutes Convertor\n");
        Console.Write("Enter the number of hours: ");

        string? input = Console.ReadLine();


        if (int.TryParse(input, out int hours))
        {
            int minutes = hours * 60;
            Console.WriteLine($"{hours} hour(s) is equal to {minutes} minutes.\n");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey(true);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.\n");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey(true);
        }
    }
}