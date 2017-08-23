using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main() // 100/100
    {
        List<int> firstLine = Console.ReadLine().Split().Select(int.Parse).ToList();
        List<int> secondLine = Console.ReadLine().Split().Select(int.Parse).ToList();

        int firstMin = Math.Abs(firstLine.Min(element => Math.Abs(element)));
        int secoundMIn = Math.Abs(secondLine.Min(element => Math.Abs(element)));

        int min = Math.Min(firstMin, secoundMIn);

        for (int i = 0; i < firstLine.Count; i++)
        {
            if (Math.Abs(firstLine[i]).ToString().Length > min.ToString().Length)
            {
                firstLine.Remove(firstLine[i]);
                i--;
            }
        }
        for (int i = 0; i < secondLine.Count; i++)
        {
            if (Math.Abs(secondLine[i]).ToString().Length > min.ToString().Length)
            {
                secondLine.Remove(secondLine[i]);
                i--;
            }
        }
        List<int> printAnswer = new List<int>();

        for (int i = 0; i < Math.Max(firstLine.Count, secondLine.Count); i++)
        {
            if (i < secondLine.Count)
            {
                printAnswer.Add(secondLine[i]);
            }
            if (i < firstLine.Count)
            {
                printAnswer.Add(firstLine[i]);
            }
        }
        Console.WriteLine(string.Join(" ", printAnswer));
    }
}