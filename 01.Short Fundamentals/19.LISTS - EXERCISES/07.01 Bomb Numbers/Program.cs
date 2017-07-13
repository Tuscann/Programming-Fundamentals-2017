using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        List<int> lineOfDigits = Console.ReadLine().Split().Select(int.Parse).ToList();
        int[] bombSpecifics = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int bombingDigit = bombSpecifics[0];
        int bombingRange = bombSpecifics[1];

        for (int cycle = 0; cycle < lineOfDigits.Count; cycle++)
        {
            if (lineOfDigits[cycle] == bombingDigit)
            {
                if (cycle >= bombingRange && bombingRange <= lineOfDigits.Count - cycle - 1) // ideal condition
                {
                    lineOfDigits.RemoveRange(cycle - bombingRange, bombingRange * 2 + 1);
                }
                else if (cycle < bombingRange && bombingRange <= lineOfDigits.Count - cycle) //short on left
                {
                    lineOfDigits.RemoveRange(0, 2 * bombingRange - cycle + 1);
                }
                else if (cycle >= bombingRange && lineOfDigits.Count - cycle - 1 < bombingRange) //short on right
                {
                    lineOfDigits.RemoveRange(cycle - bombingRange, bombingRange + lineOfDigits.Count - cycle);
                }
                cycle = -1;
            }
        }
        Console.WriteLine(lineOfDigits.Sum());
    }
}