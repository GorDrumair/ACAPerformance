using System;
using System.Diagnostics;
using System.Text;

namespace VehicleRegistrationSystem;

class Program
{
    static void Main()
    {
        StringBuilder stringBuilder = new StringBuilder("\nYour vehicle parameters.");
        int currentYear = 2025;

        Console.WriteLine("Welcome to Vehicle Registration Service!\nLet's started");
        Console.WriteLine("Enter your vehicle parameters.");
        Console.Write("Brand: ");
        string? brand = Console.ReadLine();
        stringBuilder.Append("\nBrand: " + brand);
        Console.Write("Model: ");
        string? model = Console.ReadLine();
        stringBuilder.Append("\nModel: " + model);
        Console.Write("Year: ");
        int year = Convert.ToInt32(Console.ReadLine());
        stringBuilder.Append("\nYear: " + year);
        Console.Write("Engine Capacity: ");
        double engineCapacity = Convert.ToDouble(Console.ReadLine());
        stringBuilder.Append("\nEngine Capacity: " + engineCapacity);
        Console.Write("Owner Name: ");
        string? ownerName = Console.ReadLine();
        stringBuilder.Append("\nOwner Name: " + ownerName);


        if (year >= 1980 && year <= currentYear && engineCapacity > 0)
            Console.WriteLine("Registration is success!" + stringBuilder);
        else
            Console.WriteLine("Registration is failed!\nYour car is too old.");
    }
}