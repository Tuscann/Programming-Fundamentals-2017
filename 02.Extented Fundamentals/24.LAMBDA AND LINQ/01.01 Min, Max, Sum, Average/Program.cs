using System;
using System.Collections.Generic;
using System.Linq;
public class Program
{
    public static void Main()  // 100/100
    {
        int num = int.Parse(Console.ReadLine());

        List<int> numbers = new List<int>();

        for (int i = 0; i < num; i++)
        {
            numbers.Add(int.Parse(Console.ReadLine()));
        }

        Console.WriteLine($"Sum = {numbers.Sum()}");
        Console.WriteLine($"Min = {numbers.Min()}");
        Console.WriteLine($"Max = {numbers.Max()}");
        Console.WriteLine($"Average = {numbers.Average()}");
    }
}