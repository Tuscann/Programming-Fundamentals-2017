using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        List<int> upperZip = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        List<int> lowerZip = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        int firstCounter = 0;
        int latterCounter = 100;
        int biggestCounter = 100;

        FindTheSmallestDigit(lowerZip, ref firstCounter, ref latterCounter, ref biggestCounter);
        FindTheSmallestDigit(upperZip, ref firstCounter, ref latterCounter, ref biggestCounter);
        RemoveBiggestNumbers(lowerZip, biggestCounter);
        RemoveBiggestNumbers(upperZip, biggestCounter);

        List<int> printAnswer = new List<int>();
        for (int cycle = 0; cycle < Math.Max(upperZip.Count, lowerZip.Count); cycle++)
        {
            if (cycle < lowerZip.Count)
            {
                printAnswer.Add(lowerZip[cycle]);
            }
            if (cycle < upperZip.Count)
            {
                printAnswer.Add(upperZip[cycle]);
            }
        }
        Console.WriteLine(string.Join(" ", printAnswer));
    }

    static void FindTheSmallestDigit(List<int> upperZip, ref int firstCounter, ref int latterCounter, ref int biggestCounter)
    {
        for (int upperCycle = 0; upperCycle < upperZip.Count; upperCycle++)
        {
            firstCounter = 0;
            string enumerate = upperZip[upperCycle].ToString();
            foreach (char character in enumerate)
            {
                if (character == '-')
                {
                    continue;
                }
                firstCounter++;
            }
            if (Math.Min(latterCounter, firstCounter) < biggestCounter)
            {
                biggestCounter = Math.Min(latterCounter, firstCounter);
            }
            latterCounter = firstCounter;
        }
    }

    static void RemoveBiggestNumbers(List<int> upperZip, int biggestCounter)
    {
        for (int upperCycle = 0; upperCycle < upperZip.Count; upperCycle++)
        {
            int finalCounter = 0;
            string enumerate = upperZip[upperCycle].ToString();
            foreach (char character in enumerate)
            {
                if (character == '-')
                {
                    continue;
                }
                finalCounter++;

            }
            if (finalCounter > biggestCounter)
            {
                upperZip.RemoveAt(upperCycle);
                upperCycle--;
            }
            finalCounter = 0;
        }
    }
}
