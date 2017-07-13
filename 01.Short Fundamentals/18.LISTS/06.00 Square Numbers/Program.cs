using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        List<int> output = new List<int>();

        foreach (int number in input)
        {
            if (Math.Sqrt(number) == (int)Math.Sqrt(number))
            {
                output.Add(number);
            }
        }
        output.Sort((a, b) => b.CompareTo(a));

        Console.WriteLine(string.Join(" ", output));
    }
}