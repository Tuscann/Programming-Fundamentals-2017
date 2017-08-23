using System;
using System.Collections.Generic;
using System.Linq;
public class EqualSumAfterExtraction
{
    public static void Main() // 100/100
    {
        List<int> firstListOfInt = Console.ReadLine().Split()
            .Select(int.Parse).ToList();

        List<int> secondListOfInt = Console.ReadLine()
            .Split().Select(int.Parse).ToList();

        foreach (int item in firstListOfInt)
        {
            secondListOfInt.Remove(item);
        }

        int sumFirts = firstListOfInt.Sum();
        int sumSecond = secondListOfInt.Sum();

        int diff = Math.Abs(sumFirts - sumSecond);
        if (sumFirts == sumSecond)
        {
            Console.WriteLine($"Yes. Sum: {sumFirts}");
        }
        else
        {
            Console.WriteLine($"No. Diff: {diff}");
        }
    }
}