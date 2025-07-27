using System;

namespace HoareSort;

class Program
{
    public static void Main()
    {
        int[] numbers = { 2, 3, 6, 5, 9, 8, 1 };

        int[] SortedArray = new int[numbers.Length];

        SortedArray = HoareSort(numbers);

        foreach (int i in SortedArray)
        {
            Console.WriteLine(i);
        }
    }

    public static int[] HoareSort(int[] numbers)
    {
        int left = 0;
        int right = numbers.Length - 1;
        int pivot = numbers[(left + right) / 2];

        while (left <= right)
        {
            while (numbers[left] < pivot) left++;
            while (numbers[right] > pivot) right--;
            if (left <= right)
            {
                Swipe(left, right, numbers);
                left++;
                right--;
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