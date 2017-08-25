using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main() // 100/100
    {
        List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        while (true)
        {
            string commnad = Console.ReadLine();
            if (commnad == "end")
            {
                break;
            }
            int number = int.Parse(commnad);
            int index = int.Parse(commnad.Substring(0, 1));

            input.Insert(index, number);
        }
        Console.WriteLine(string.Join(" ", input));
    }
}