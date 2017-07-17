using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
        List<double> output = new List<double>();

        for (int i = 0; i < input.Count; i++)
        {
            if ((input[i] & 1) == 0)
            {
                output.Add(input[i]);
                input.Remove(input[i]);
            }
        }
        double average = output.Average();

        for (int i = 0; i < output.Count; i++)
        {
            if (output[i] > average)
            {
                output[i]++;
            }
            if (output[i] <= average)
            {
                output[i]--;
            }
        }
        Console.WriteLine(string.Join(" ", output));
    }
}