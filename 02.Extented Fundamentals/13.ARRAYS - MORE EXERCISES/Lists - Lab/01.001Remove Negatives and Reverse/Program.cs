using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        List<string> items = Console.ReadLine().Split(' ').ToList();
        List<int> nums = new List<int>();
        bool isPlus = true;

        foreach (string t in items)
        {
            if (int.Parse(t) > 0)
            {
                nums.Add(int.Parse(t));
                isPlus = false;
            }
        }
        nums.Reverse();
        if (isPlus)
        {
            Console.WriteLine("empty");
        }
        else
        {
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}