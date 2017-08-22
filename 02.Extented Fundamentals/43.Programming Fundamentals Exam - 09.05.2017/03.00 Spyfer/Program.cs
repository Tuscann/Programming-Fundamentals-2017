using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main() // 100/100
    {
        List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
        
        for (int i = 0; i < input.Count; i++)
        {
            int currentNumber = input[i];

            if (i != 0 && i != input.Count - 1)
            {
                int sumOfNeighbours = input[i - 1] + input[i + 1];

                if (currentNumber == sumOfNeighbours)
                {
                    input.RemoveAt(i + 1);
                    input.RemoveAt(i - 1);
                    i = 0;
                }
            }
            else if (i == 0 && currentNumber == input[i + 1])
            {
                input.RemoveAt(i + 1);
                i = 0;
            }
            else if (i == input.Count - 1 && currentNumber == input[i - 1])
            {
                input.RemoveAt(i - 1);
                i = 0;
            }
        }
        Console.WriteLine(string.Join(" ", input));
    }
}