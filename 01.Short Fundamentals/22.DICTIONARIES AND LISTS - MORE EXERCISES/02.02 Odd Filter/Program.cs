using System;
using System.Collections.Generic;
using System.Linq;
class P02_OddFilter
{
    static void Main()
    {
        List<int> numList = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .Where(x => x % 2 == 0)
            .ToList();

        double numListAvetage = numList.Average();

        numList = numList.Select(x => x = x > numListAvetage ? ++x : --x)
            .ToList();
        Console.WriteLine(string.Join(" ", numList));
    }
}
