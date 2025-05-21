using System;

namespace PracticeProgram;

class Program
{
    static void Main(string[] args)
    {
        int maxNumber1 = int.MinValue;
        int maxNumber2 = int.MinValue;
        int minNumber1 = int.MaxValue;
        int minNumber2 = int.MaxValue;
        int iterationCount = 100;

        for (int i = 0; i < iterationCount; i++)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 101);
            Console.WriteLine($"Random number: {randomNumber}");

            if (randomNumber > maxNumber1)
            {
                maxNumber2 = maxNumber1;
                maxNumber1 = randomNumber;
            }
            else if (randomNumber > maxNumber2)
            {
                maxNumber2 = randomNumber;
            }

            if (randomNumber < minNumber1)
            {
                minNumber2 = minNumber1;
                minNumber1 = randomNumber;
            }
            else if (randomNumber < minNumber2)
            {
                minNumber2 = randomNumber;
            }
        }


        Console.WriteLine($"Max number 1: {maxNumber1}");
        Console.WriteLine($"Max number 2: {maxNumber2}");
        Console.WriteLine($"Min number 1: {minNumber1}");
        Console.WriteLine($"Min number 2: {minNumber2}");

        Console.WriteLine($"Max number 1: {maxNumber1 + minNumber1 / iterationCount}");
        Console.WriteLine($"Max number 2: {maxNumber2 + minNumber2 / iterationCount}");
    }
}