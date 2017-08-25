using System;
using System.Linq;
class Program
{
    static void Main() // 100/100
    {
        int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int n = int.Parse(Console.ReadLine());
        bool isFound = true;

        foreach (int t in input)
        {
            if (t == n)
            {
                isFound = false;
            }
        }
        Console.WriteLine(isFound ? "no" : "yes");
    }
}