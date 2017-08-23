using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main() // 100/100
    {
        List<int> listNums = Console.ReadLine().Split().Select(int.Parse).ToList().OrderBy(x => -x).ToList();

        List<int> xa = listNums.Where(n => n > listNums.Average()).Take(5).ToList();

        Console.WriteLine(listNums.Distinct().Skip(1).Any().ToString() == "False" ? "No" : string.Join(" ", xa));
    }
}