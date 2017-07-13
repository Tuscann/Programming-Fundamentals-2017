using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        var sequence = Console.ReadLine().Split().Select(int.Parse).ToArray();

        var longestSeq = FindLongestIncreasingSubsequence(sequence);

        Console.WriteLine("{0}", string.Join(" ", longestSeq));
    }

    public static int[] FindLongestIncreasingSubsequence(int[] sequence)
    {
        int[] length = new int[sequence.Length];
        int[] prev = new int[sequence.Length];
        int maxLength = 0;
        int lastIndex = -1;

        for (int i = 0; i < sequence.Length; i++)
        {
            length[i] = 1;
            prev[i] = -1;

            for (int j = 0; j < i; j++)
            {
                if (sequence[j] < sequence[i] && length[j] >= length[i])
                {
                    length[i] = 1 + length[j];
                    prev[i] = j;
                }
            }

            if (length[i] > maxLength)
            {
                maxLength = length[i];
                lastIndex = i;
            }
        }

        var longestSeq = new List<int>();
        for (int i = 0; i < maxLength; i++)
        {
            longestSeq.Add(sequence[lastIndex]);
            lastIndex = prev[lastIndex];
        }

        longestSeq.Reverse();
        return longestSeq.ToArray();
    }
}