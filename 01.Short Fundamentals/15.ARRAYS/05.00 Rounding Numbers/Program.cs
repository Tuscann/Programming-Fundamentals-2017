using System;
using System.Linq;
class Program
{
    static void Main() // 100/100
    {
        double[] nums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

        int[] roundedNums = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            roundedNums[i] = (int)Math.Round(nums[i], MidpointRounding.AwayFromZero);
            Console.WriteLine($"{nums[i]} -> {roundedNums[i]}");
        }
    }
}