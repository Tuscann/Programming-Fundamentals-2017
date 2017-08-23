using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        List<long> input = Console.ReadLine()
            .Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(long.Parse)
            .ToList();

        long sumOfAllRemoved = 0;

        while (input.Count > 0)
        {
            int index = int.Parse(Console.ReadLine());
            long currentValue = 0;

            if (index < 0)
            {
                currentValue = input[0];
                sumOfAllRemoved += currentValue;
                input[0] = input[input.Count - 1];
            }
            else if (index > input.Count - 1)
            {
                currentValue = input[input.Count - 1];
                sumOfAllRemoved += currentValue;
                input[input.Count - 1] = input[0];
            }
            else
            {
                currentValue = input[index];
                sumOfAllRemoved += currentValue;
                input.RemoveAt(index);
            }

            for (int cycle = 0; cycle < input.Count; cycle++)
            {
                if (input[cycle] <= currentValue)
                {
                    input[cycle] += currentValue;
                }
                else
                {
                    input[cycle] -= currentValue;
                }
            }
        }
        Console.WriteLine(sumOfAllRemoved);
    }
}