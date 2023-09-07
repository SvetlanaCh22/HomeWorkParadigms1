using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 5, 2, 9, 1, 3 };
        
        // Вызываем процедуру сортировки в порядке убывания
        SortNumbersDescending(numbers);
        
        // Выводим отсортированный список
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
    
    public static void SortNumbersDescending(List<int> numbers)
    {
        numbers.Sort((a, b) => b.CompareTo(a));
    }
}