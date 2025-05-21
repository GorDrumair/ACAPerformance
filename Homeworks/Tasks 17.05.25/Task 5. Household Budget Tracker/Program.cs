using System;

namespace HouseholdBudgetTracker;

class Program
{
    static void Main()
    {
        Console.Write("Enter your monthly income budget: ");
        decimal budget = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter your expences for...");
        Console.Write("Rent: ");
        decimal rent = Convert.ToInt32(Console.ReadLine() ?? "0");
        Console.Write("Groceries: ");
        decimal groceries = Convert.ToInt32(Console.ReadLine() ?? "0");
        Console.Write("Transport: ");
        decimal transport = Convert.ToInt32(Console.ReadLine() ?? "0");
        Console.Write("Enterteinment: ");

        decimal totalExpences = rent + groceries + transport;
        decimal remainder = budget - rent - groceries - transport;

        if (remainder < 0 || (budget * 80 / 100) <= (budget / remainder * 100))
        {
            Console.WriteLine("Attention, you have a lot of expenses.");
        }
        else
        {
            Console.WriteLine($"Your totla expences - {totalExpences}$");
            Console.WriteLine($"Now your budget is - {remainder}$");
        }
    }
}