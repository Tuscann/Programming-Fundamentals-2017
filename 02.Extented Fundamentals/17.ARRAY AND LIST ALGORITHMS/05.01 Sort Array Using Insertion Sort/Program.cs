using System;
using System.Collections.Generic;
using System.Linq;
class SortNumbers_2
{
    static List<decimal> numbers = GetNewList(numbers);

    static void Main() // 100/100
    {
        SortList(numbers);
        string result = GetAResult(numbers);
        Console.WriteLine(result);
    }

    static List<decimal> GetNewList(List<decimal> numbers)
    {
        numbers = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
        return numbers;
    }

    static List<decimal> SortList(List<decimal> numbers)
    {
        numbers.Sort();
        return numbers;
    }

    static string GetAResult(List<decimal> numbers)
    {
        string result = String.Join(" ", numbers);
        return result;
    }
}