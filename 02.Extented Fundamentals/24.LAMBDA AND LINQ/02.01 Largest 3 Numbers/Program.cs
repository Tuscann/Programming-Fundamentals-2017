using System;
using System.Linq;
public class Program
{
    public static void Main() // 100/100
    {
        int[] numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .OrderByDescending(x => x)
            .Take(3)
            .ToArray();

        Console.WriteLine($"{string.Join(" ", numbers)}");
    }
}