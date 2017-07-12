using System;
using System.Linq;
public class Program
{
    public static void Main(string[] args)
    {
        int[] sequence = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int middleStartIndex = sequence.Length / 4;
        int middleEndIndex = middleStartIndex + sequence.Length / 2;

        int summingIndex = middleStartIndex - 1;

        for (int i = middleStartIndex; i < middleEndIndex; i++)
        {
            int sum = sequence[i] + sequence[summingIndex];
            Console.Write($"{sum} ");
            summingIndex--;
            if (summingIndex < 0)
            {
                summingIndex = sequence.Length - 1;
            }
        }
    }
}