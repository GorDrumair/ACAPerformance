using System;

namespace FuelPumpSimulation;

class Program
{
    static void Main(string[] args)
    {
        double pricePerGallon = 3.165;
        Console.WriteLine($"Welcome to CPS Gas Station!\nPrice per gallon: {pricePerGallon}");
        Console.Write("\nPlease enter the amount of fuel in gallons:");
        int fuelAmount = Convert.ToInt32(Console.ReadLine());
        int i = 0;
        
        while (i < fuelAmount)
        {
            i++;
            Console.WriteLine($"Fuel pumped 1 gallon. Total {i} gallons.");
            System.Threading.Thread.Sleep(1000);
        }

        double totalCost = fuelAmount * pricePerGallon;
        Console.WriteLine($"Total cost: ${totalCost:F2}");
    }
}