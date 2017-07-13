using System;
using System.Collections.Generic;
using System.Linq;
class Max_Sequence_of_Equal_Elements
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();
        List<int> longestSeq = GetLongestSequence(numbers);
        Console.WriteLine(string.Join(" ", longestSeq));
    }

    private static List<int> GetLongestSequence(List<int> numbers)
    {
        int maxLen = 1;
        int maxIndex = 0;
        int currentLen = 1;
        int currentIndex = 0;

        for (int i = 1; i < numbers.Count; i++)
        {
            if (numbers[i] == numbers[i - 1])
            {
                currentLen++;
            }
            else
            {
                currentIndex = i;
                currentLen = 1;
            }
            if (maxLen < currentLen)
            {
                maxLen = currentLen;
                maxIndex = currentIndex;
            }
        }
        List<int> longestSeq = new List<int>();
        for (int len = 0; len < maxLen; len++)
            longestSeq.Add(numbers[maxIndex + len]);
        return longestSeq;
    }
}
