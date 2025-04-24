using System;

namespace SimpleMathPractice;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Simple Math Practice\n");

        Console.Write("Enter the first number: ");
        string? input1 = Console.ReadLine();
        Console.Write("Enter the second number: ");
        string? input2 = Console.ReadLine();


        if (int.TryParse(input1, out int number1) && int.TryParse(input2, out int number2))
        {
            Console.WriteLine($"\nAddition: {number1} + {number2} = {number1 + number2}");
            Console.WriteLine($"Subtraction: {number1} - {number2} = {number1 - number2}");
            Console.WriteLine($"Multiplication: {number1} * {number2} = {number1 * number2}");
            Console.WriteLine($"Division: {number1} / {number2} = {(number2 != 0 ? (double)number1 / number2 : "underfined (division by zero)")}\n");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter valid numbers.\n");
        }

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey(true);
    }
}