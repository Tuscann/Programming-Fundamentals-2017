using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int power = numbers[1];
        int index = input.IndexOf(numbers[0]);

        int starIndex = Math.Max(0, index - power);
        int endIndex = Math.Min(index + power, input.Count - 1);

        int counter = 0;

        for (int i = 0; i < input.Count - 1; i++)
        {
            if (i == starIndex)
            {
                input.RemoveAt(input[i]);
                i--;
                counter++;
                if (counter == endIndex - starIndex)
                {
                    break;
                }
            }
        }
        Console.WriteLine(string.Join(" ", input));
        Console.WriteLine(string.Join(" ", input.Sum()));

    }
}