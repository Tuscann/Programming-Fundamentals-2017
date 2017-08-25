using System;
using System.Collections.Generic;
using System.Linq;
public class Program
{
    public static void Main() //100/100
    {
        int numOfLines = int.Parse(Console.ReadLine());
        List<int> sequence = Console.ReadLine()
            .Split().Select(int.Parse).ToList();

        for (int i = 0; i < numOfLines - 1; i++)
        {
            List<int> currentSequence = Console.ReadLine()
                .Split().Select(int.Parse).ToList();
            int index = 0;

            for (int find = 0; find < sequence.Count; find++)
            {
                if (sequence[find] <= currentSequence[0])
                {
                    index++;
                }
                else
                {
                    break;
                }
            }

            for (int k = 0; k < currentSequence.Count; k++)
            {
                sequence.Insert(index + k, currentSequence[k]);
                if (index + k != sequence.Count - 1)
                {
                    if (currentSequence[k] > sequence[index + k + 1])
                    {
                        break;
                    }
                }
            }

            index = 0;
            bool isBroken = false;

            for (int broken = 1; broken < sequence.Count; broken++)
            {
                if (sequence[broken - 1] > sequence[broken])
                {
                    isBroken = true;
                    index = broken;
                    break;
                }
            }

            if (isBroken)
            {
                sequence.RemoveRange(index, sequence.Count - index);
            }
        }
        Console.WriteLine(string.Join(" ", sequence));
    }
}