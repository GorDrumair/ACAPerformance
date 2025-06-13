using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace PracticeProgram;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        Array array = Array.CreateInstance(typeof(int), 100);

        int arrayMinValue = int.MaxValue;
        int arrayMaxValue = int.MinValue;
        int arraySum = 0;
        double arrayAvarge;

        for (int i = 0; i < 100; i++)
        {
            int j = random.Next(1, 1000);
            array.SetValue(j, i);

            arrayMaxValue = j > arrayMaxValue ? j : arrayMaxValue;
            arrayMinValue = j < arrayMinValue ? j : arrayMinValue;
            arraySum += j;
        }

        arrayAvarge = arraySum / array.Length;


        Console.WriteLine($"Max Value: {arrayMaxValue}");
        Console.WriteLine($"Min Value: {arrayMinValue}");
        Console.WriteLine($"Sum: {arraySum}");
        Console.WriteLine($"Avarge: {arrayAvarge}");
    }   
}