using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>() { 5, 3, 8, 2, 1 };
        SortDescending(numbers);

        Console.WriteLine("ќтсортированный список чисел в пор€дке убывани€:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }

    static void SortDescending(List<int> numbers)
    {
        for (int i = 1; i < numbers.Count; i++)
        {
            int key = numbers[i];
            int j = i - 1;

            while (j >= 0 && numbers[j] < key)
            {
                numbers[j + 1] = numbers[j];
                j = j - 1;
            }

            numbers[j + 1] = key;
        }
    }
}