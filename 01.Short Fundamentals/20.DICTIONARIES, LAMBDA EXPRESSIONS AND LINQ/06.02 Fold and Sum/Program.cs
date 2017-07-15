using System;
using System.Linq;
public class FoldAndSum
{
    public static void Main()
    {
        int[] numbers = Console.ReadLine()
            .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        int quarter = numbers.Length / 4;

        int[] firstUpperPart = numbers
            .Take(quarter)
            .Reverse()
            .ToArray();

        int[] secondUpperPart = numbers
            .Reverse()
            .Take(quarter)
            .ToArray();

        int[] upperNumbers = firstUpperPart
            .Concat(secondUpperPart)
            .ToArray();

        int[] lowerNumbers = numbers
            .Skip(quarter)
            .Take(2 * quarter)
            .ToArray();

        int[] resultNumbers = upperNumbers.Select((x, index) => x + lowerNumbers[index]).ToArray();

        Console.WriteLine(string.Join(" ", resultNumbers));
    }
}