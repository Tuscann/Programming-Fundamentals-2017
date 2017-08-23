using System;
using System.Collections.Generic;
using System.Linq;
public class RemoveNegativesAndReverse
{
    public static void Main() // 100/100
    {
        List<int> numbers = Console.ReadLine()
            .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .Where(x => x > 0)
            .Reverse()
            .ToList();

        if (numbers.Count == 0)
        {
            Console.WriteLine("empty");
        }
        else
        {
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}