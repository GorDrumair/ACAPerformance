using System;

namespace DiceRollGame;

class Program
{
    static void Main(string[] args)
    {
        int rollsCounter = 0;
        Random random = new Random();
        Console.WriteLine("Welcome to the Dice Roll Game!");
        Console.WriteLine("Press Enter to roll the dice.");
        
        while (true)
        {
            Console.ReadKey(true); 
            int diceRoll = random.Next(1, 7);
            Console.WriteLine($"Rolling result is: {diceRoll}!");
            rollsCounter++;
            if (diceRoll == 6)
            {
                break;
            }
        }
        Console.WriteLine($"You rolled the dice {rollsCounter} times before rolling a 6.");
        Console.WriteLine("Thanks for playing! Press any key to exit.");
        Console.ReadKey(true);
    }
}