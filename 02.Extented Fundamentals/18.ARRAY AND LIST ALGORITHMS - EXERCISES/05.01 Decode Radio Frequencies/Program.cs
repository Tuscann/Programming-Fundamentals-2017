using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main() // 100/100
    {
        List<int> radioFreqs = Console.ReadLine().Split(new char[] { ' ', '.' }).Select(int.Parse).ToList();

        List<int> leftDigits = new List<int>();
        List<int> rightDigits = new List<int>();

        for (int cycle = 0; cycle < radioFreqs.Count; cycle++)
        {
            if (cycle % 2 == 0 && radioFreqs[cycle] != 0)
            {
                leftDigits.Add(radioFreqs[cycle]);
            }
            else if (cycle % 2 == 1 && radioFreqs[cycle] != 0)
            {
                rightDigits.Add(radioFreqs[cycle]);
            }
        }
        rightDigits.Reverse();

        for (int cycleAnswer = 0; cycleAnswer < leftDigits.Count; cycleAnswer++)
        {
            Console.Write((char)leftDigits[cycleAnswer]);
        }
        for (int cycleAnswer = 0; cycleAnswer < rightDigits.Count; cycleAnswer++)
        {
            Console.Write((char)rightDigits[cycleAnswer]);
        }
        Console.WriteLine();
    }
}