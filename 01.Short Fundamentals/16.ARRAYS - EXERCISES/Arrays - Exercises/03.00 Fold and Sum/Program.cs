using System;
using System.Linq;
using System.IO;

namespace FoldAndSum
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] sequence = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int middleStartIndex = CalculateStartingIndex(sequence);
            int middleEndIndex = CalculateEndingIndex(sequence);

            PrintFoldSum(middleStartIndex, middleEndIndex, sequence, middleStartIndex - 1, Console.Out);
        }

        static int CalculateStartingIndex(int[] sequence)
        {
            int half = sequence.Length / 2;
            int quarter = half / 2;

            return quarter;
        }

        static int CalculateEndingIndex(int[] sequence)
        {
            int half = sequence.Length / 2;
            int end = half + CalculateStartingIndex(sequence);

            return end;
        }

        static int TryMoveSummingIndexToEnd(int summingIndex, int[] sequence)
        {
            if (summingIndex < 0)
            {
                summingIndex = sequence.Length - 1;
            }

            return summingIndex;
        }

        static void PrintFoldSum(int middleStartIndex,
            int middleEndIndex,
            int[] sequence,
            int summingIndex,
            TextWriter writer)
        {
            for (int i = middleStartIndex; i < middleEndIndex; i++)
            {
                int sum = sequence[i] + sequence[summingIndex];
                writer.Write($"{sum} ");
                summingIndex = TryMoveSummingIndexToEnd(summingIndex - 1, sequence);
            }
        }
    }
}