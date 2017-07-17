using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        List<char> inputLine = Console.ReadLine().ToList();

        List<int> whetherOddOrEvenDigits = new List<int>();
        List<char> lettersToDrawFrom = new List<char>();

        List<int> skipList = new List<int>();
        List<int> takeList = new List<int>();

        for (int cycle1 = 0; cycle1 < inputLine.Count; cycle1++)
        {
            if (inputLine[cycle1].ToString().All(char.IsDigit))  // IsDigit
            {
                whetherOddOrEvenDigits.Add(int.Parse(inputLine[cycle1].ToString()));
            }
            else
            {
                lettersToDrawFrom.Add(inputLine[cycle1]);
            }
        }

        for (int cycle2 = 0; cycle2 < whetherOddOrEvenDigits.Count; cycle2++)
        {
            if (cycle2 % 2 == 0)
            {
                takeList.Add(whetherOddOrEvenDigits[cycle2]);
            }
            else
            {
                skipList.Add(whetherOddOrEvenDigits[cycle2]);
            }
        }
        int addingSkipCount = 0;

        for (int cycle3 = 0; cycle3 < takeList.Count; cycle3++)
        {
            List<char> takeSkipList = lettersToDrawFrom
                .Skip(addingSkipCount)
                .Take(takeList[cycle3])
                .ToList();

            Console.Write(string.Join("", takeSkipList));
            addingSkipCount += takeList[cycle3] + skipList[cycle3];
        }
    }
}