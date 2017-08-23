using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main() // 100/100
    {
        List<int> listNums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        foreach (int number in listNums.OrderByDescending(x => x).Take(5))
        {
            if (number > listNums.Average())
            {
                Console.Write(number + " ");
            }
        }
        if (listNums.Max() <= listNums.Average())
        {
            Console.WriteLine("No");
        }
    }
}