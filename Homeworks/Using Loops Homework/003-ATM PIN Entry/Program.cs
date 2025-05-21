using System;

namespace ATM_PIN_Entry;

class Program
{
    static void Main(string[] args)
    {
        int i = 3;
        do
        {
            Console.Write("Please enter you PIN: ");
            string? pin = Console.ReadLine();
            if (pin == "1234")
            {
                Console.WriteLine("PIN accepted. Access granted.");
                break;
            }
            else
            {
                Console.WriteLine("Incorrect PIN. Please try again.");
                i--;
            }
        }
        while (i > 0);
        if (i == 0)
            Console.WriteLine("Too many attempts. Access denied.");
    }
}