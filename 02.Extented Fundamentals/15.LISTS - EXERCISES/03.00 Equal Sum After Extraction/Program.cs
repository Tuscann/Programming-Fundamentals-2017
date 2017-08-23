using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main() // 100/100
    {
        List<int> firstList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        List<int> secoundList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        for (int i = 0; i < secoundList.Count; i++)
        {
            if (firstList.Contains(secoundList[i]))
            {
                secoundList.Remove(secoundList[i]);
            }
        }

        if (firstList.Sum() == secoundList.Sum())
        {
            Console.WriteLine("Yes. Sum: {0}", firstList.Sum());
        }
        else
        {
            Console.WriteLine("No. Diff: {0}", Math.Abs(firstList.Sum() - secoundList.Sum()));
        }
    }
}