using System;
using System.Collections.Generic;
using System.Linq;
public class TearInHalf
{
    public static void Main() // 100/100
    {
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] firstHalf = input.Take(input.Length / 2).ToArray();
        int[] secondHalf = input.Skip(input.Length / 2).ToArray();
        int lenght = input.Length + input.Length / 2;
        List<int> result = new List<int>(lenght);

        for (int i = 0; i < firstHalf.Length; i++)
        {
            result.Add(secondHalf[i] / 10);
            result.Add(firstHalf[i]);
            result.Add(secondHalf[i] % 10);
        }
        Console.WriteLine(string.Join(" ", result));
    }
}