using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        List<double> nums = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
        SortedDictionary<double, int> counts = new SortedDictionary<double, int>();

        foreach (double num in nums)
        {
            if (counts.ContainsKey(num))
            {
                counts[num]++;
            }
            else
            {
                counts[num] = 1;
            }
        }
        foreach (double num in counts.Keys)
        {
            Console.WriteLine("{0} -> {1}", num, counts[num]);
        }
    }
}