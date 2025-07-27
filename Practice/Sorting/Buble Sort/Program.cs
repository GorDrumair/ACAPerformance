using System;

namespace BubbleSort;

class Program
{
    public static void Main(string[] args)
    {
        int[] numbers = { 1, 10, 6, 8, 7, 5, 9 };

        int[] arr = new int[numbers.Length];
        arr = Sort(numbers);

        foreach (var i in arr)
        {
            Console.WriteLine(i);
        }
    }

    public static int[] Sort(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = 0; j < numbers.Length - (i + 1); j++)
            {
                if (numbers[j] > numbers[j + 1])
                {
                    Swipe(j, j + 1, numbers);
                }
            }
        }

        return numbers;
    }

    public static void Swipe(int index1, int index2, int[] tempArray)
    {
        int temp = tempArray[index1];
        tempArray[index1] = tempArray[index2];
        tempArray[index2] = temp;
    }
}

