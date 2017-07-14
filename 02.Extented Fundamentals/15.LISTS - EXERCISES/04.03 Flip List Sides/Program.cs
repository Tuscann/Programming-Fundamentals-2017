using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        var number = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
        var num = new List<int>();
        var nums = new List<int>();
        for (int i = 1; i <= number.Count - 2; i++)
        {
            nums.Add(number[i]);
        }
        nums.Reverse();
        num.Add(number[0]);
        num.AddRange(nums);
        num.Add(number[number.Count - 1]);
        Console.WriteLine(string.Join(" ", num));
    }
}
