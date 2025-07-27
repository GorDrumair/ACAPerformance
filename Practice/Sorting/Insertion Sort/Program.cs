using System;

namespace InsertoinSort;

class Program
{
    public static void Main()
    {
        int[] numbers = { 1, 9, 8, 5, 6, 7, 3, 4 };
        int[] SortedArray = new int[numbers.Length];

        SortedArray = Sort(numbers);

        foreach (var i in SortedArray)
        {
            Console.WriteLine(i);
        }
    }

    public static int[] Sort(int[] numbers)
    {
        for (int i = 1; i < numbers.Length; i++)
        {
            int sorted = i - 1;
            while (i > -1 && numbers[sorted] > numbers[sorted + 1])
            {
                Swipe(sorted, sorted + 1, numbers);
                sorted--;
            }
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