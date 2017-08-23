using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main() // 100/100
    {
        List<int> number = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
        List<int> num = new List<int>();
        List<int> nums = new List<int>();
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