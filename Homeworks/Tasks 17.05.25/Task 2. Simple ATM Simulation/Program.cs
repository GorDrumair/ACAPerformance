using System;

namespace SimpleATMSimulation;

class Program
{
    static void Main()
    {
        decimal Balance = 10000;

        Console.WriteLine("Welcome to ATM\n 1. Check Balance\n 2. Deposite\n 3. Withdraw\n 4. Exit\n");
        Console.Write("Enter you action (number): ");
        int action = Convert.ToInt32(Console.ReadLine());

        switch (action)
        {
            case 1:
                Console.WriteLine($"Your balance is: {Balance}$");
                break;
            case 2:
                Console.Write("Enter value to deposit: ");
                Balance += Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine($"Now your balance is: {Balance}$");
                break;
            case 3:
                Console.Write("Enter value to withdrawals: ");
                decimal withdrawals = Convert.ToInt32(Console.ReadLine());
                if (Balance >= withdrawals)
                {
                    Balance -= withdrawals;
                    Console.WriteLine($"Now your balance is: {Balance}$");
                }   
                else
                    Console.WriteLine("Insufficient funds!");
                break;
            case 4:
                Console.WriteLine("Exiting...");
                break;
            default:
                break;
        }
    }
}