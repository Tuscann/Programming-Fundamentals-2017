using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        List<int> firstList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        List<int> secondList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        firstList.Sort(); secondList.Sort();

        for (int cycle = 0; cycle < firstList.Count; cycle++)
        {
            for (int cycle2 = 0; cycle2 < secondList.Count; cycle2++)
            {
                if (firstList[cycle] == secondList[cycle2])
                {
                    secondList[cycle2] = 0;
                }
            }
        }
        int firstSum = firstList.Sum();
        int secondSum = secondList.Sum();

        if (firstSum == secondSum)
        {
            Console.WriteLine("Yes. Sum: {0}", firstSum);
        }
        else
        {
            Console.WriteLine("No. Diff: {0}", Math.Abs(firstSum - secondSum));
        }
    }
}