using System;
using System.Globalization;

namespace SelectionSort;

class Program
{
    public static void Main(string[] args)
    {
        int[] numbers = { 5, 3, 6, 7, 2, 8, 4, 9, 1 };
        int[] arr = new int[numbers.Length];

        arr = Sort(numbers);

        foreach (var i in numbers)
        {
            Console.WriteLine(i);
        }
    }

    public static int[] Sort(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            int min_Index = i;
            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[min_Index] > numbers[j])
                {
                    min_Index = j;
                }
            }
            if (min_Index != i)
                Swipe(i, min_Index, numbers);
        }

        return numbers;
    }

    public static void Swipe(int index1, int index2, int[] numbers)
    {
        int temp = numbers[index1];
        numbers[index1] = numbers[index2];
        numbers[index2] = temp;
    }
}