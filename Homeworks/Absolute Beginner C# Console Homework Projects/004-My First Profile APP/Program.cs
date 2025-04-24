using System;

namespace MyFirstProfileApp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hi there! Create your profile, please!\nLet's do it.\n");

        Console.Write("Enter your first name: ");
        string? name = Console.ReadLine();

        Console.Write("Enter your last name: ");
        string? lastName = Console.ReadLine();

        Console.Write("Enter your age: ");
        string? age = Console.ReadLine();

        Console.Write("Enter your Country: ");
        string? country = Console.ReadLine();

        Console.WriteLine($"\nYour name is {name} {lastName}, you are {age} years old and you live in {country}.\nThank you for your time!\n");
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey(true);
    }
}