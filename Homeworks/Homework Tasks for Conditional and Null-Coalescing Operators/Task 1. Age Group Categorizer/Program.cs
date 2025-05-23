using System;

namespace AgeGroupCategorizer;

class Program
{
    static void Main()
    {
        Console.Write("Enter your age: ");
        int age;
        int.TryParse(Console.ReadLine(), out age);
        string group = "";

        //         if              |        else if                      |       else if                    |  else if             | else
        group = age < 13 ? "Child" : age >= 13 && age <= 17 ? "Teenager" : age >= 18 && age <= 64 ? "Adult" : age >= 65 ? "Senior" : "";

        Console.WriteLine($"Yuo are an: {group}");
    }
}