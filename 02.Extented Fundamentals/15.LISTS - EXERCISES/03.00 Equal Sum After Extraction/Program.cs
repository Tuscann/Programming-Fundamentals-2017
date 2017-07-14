using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
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
        //Console.WriteLine(string.Join(" ", secoundList));

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