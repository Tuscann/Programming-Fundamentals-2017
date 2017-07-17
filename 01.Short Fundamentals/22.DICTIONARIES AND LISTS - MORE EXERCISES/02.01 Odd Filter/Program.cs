using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        List<int> lineOfDigits = Console.ReadLine().Split().Select(int.Parse).ToList();

        for (int cycle = 0; cycle < lineOfDigits.Count; cycle++)
        {
            if (lineOfDigits[cycle] % 2 == 1)
            {
                lineOfDigits.RemoveAt(cycle);
                cycle--;
            }
        }
        double average = lineOfDigits.Average();

        for (int cycle2 = 0; cycle2 < lineOfDigits.Count; cycle2++)
        {
            if (lineOfDigits[cycle2] > average)
            {
                lineOfDigits[cycle2]++;
                continue;
            }
            lineOfDigits[cycle2]--;

        }
        Console.WriteLine(string.Join(" ", lineOfDigits));
    }
}