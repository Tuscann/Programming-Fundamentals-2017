using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        IEnumerable<int> nums = Console.ReadLine().Split()
            .Select(int.Parse)
            .OrderBy(x => -x)
            .Take(3);

        Console.WriteLine(string.Join(" ", nums));
    }
}