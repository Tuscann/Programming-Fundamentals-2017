using System;
using System.Collections.Generic;
using System.Linq;

public class DistinctList
{
    public static void Main() // 100/100
    {
        List<int> numbers = Console.ReadLine()
            .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();
        List<int> result = RemoveRepeatingElements(numbers);
        
        Console.WriteLine(string.Join(" ", result));
    }
    static List<int> RemoveRepeatingElements(List<int> numbers)
    {
        List<int> result = numbers;

        for (int i = 0; i < numbers.Count; i++)
        {
            int count = 0;

            for (int j = 0; j < result.Count; j++)
            {

                if (result[j] == numbers[i])
                {
                    count++;
                }
                if (count > 1)
                {
                    result.RemoveAt(j);
                    j--;
                    count--;
                }
            }
        }
        return result;
    }
}