using System;
using System.Collections.Generic;
using System.Linq;

public class DistinctList
{
    public static void Main()
    {
        var numbers = Console.ReadLine()
            .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();
        var result = RemoveRepeatingElements(numbers);

        //var result = numbers.Distinct();    //The Distinct method more easy
        Console.WriteLine(string.Join(" ", result));
    }
    static List<int> RemoveRepeatingElements(List<int> numbers)
    {
        var result = numbers;

        for (int i = 0; i < numbers.Count; i++)
        {
            var count = 0;

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
