using System;

namespace PracticeProgram;

class Program
{
    static void Main()
    {
        Console.Write("First operand: ");
        int firstOperand;
        int.TryParse(Console.ReadLine(), out firstOperand);

        Console.Write("Opration(+, -, *, /): ");        // + 43, - 45, * 42, / 47
        char operation1;
        char.TryParse(Console.ReadLine(), out operation1);

        Console.Write("Second operand: ");
        int secondOperand;
        int.TryParse(Console.ReadLine(), out secondOperand);

        Console.Write("Opration(+, -, *, /): ");
        char operation2;
        char.TryParse(Console.ReadLine(), out operation2);

        Console.Write("Third operand: ");
        int thirdOperand;
        int.TryParse(Console.ReadLine(), out thirdOperand);

        int? result = null;


        if (operation1 == 42 || operation1 == 47)
        {
            switch (operation1)
            {
                case '+':
                    break;
                case '-':
                    break;
                case '*':
                    break;
                case '/':
                    
                    break;
                default:
                    Console.WriteLine("Something is wrong!");
                    break;
            }
        }
        else if (operation2 == 42 || operation2 == 47)
        {

        }
        

    }
}