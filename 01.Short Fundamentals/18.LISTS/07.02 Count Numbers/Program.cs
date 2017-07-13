using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        List<int> lineOfDigits = Console.ReadLine().Split(' ')
        .Select(int.Parse).ToList();

        lineOfDigits.Sort();

        List<int> specificDigit = new List<int>();
        List<int> repeatedTimes = new List<int>();

        bool isLastElementPrinted = false;

        int count = 1;

        for (int cycle = 1; cycle < lineOfDigits.Count; cycle++)
        {
            if (lineOfDigits[cycle] == lineOfDigits[cycle - 1])
            {
                count++;
                if (cycle == lineOfDigits.Count - 1)
                {
                    specificDigit.Add(lineOfDigits[cycle - 1]);
                    repeatedTimes.Add(count);
                    count = 1;
                    isLastElementPrinted = true;
                }
            }
            else
            {
                specificDigit.Add(lineOfDigits[cycle - 1]);
                repeatedTimes.Add(count);
                count = 1;
            }
        }
        for (int cycle = 0; cycle < specificDigit.Count; cycle++)
        {
            Console.WriteLine($"{specificDigit[cycle]} -> {repeatedTimes[cycle]}");
        }

        if (!isLastElementPrinted)
        {
            Console.WriteLine("{0} -> 1", lineOfDigits[lineOfDigits.Count - 1]);
        }
    }
}
