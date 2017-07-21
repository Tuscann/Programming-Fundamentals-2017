using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()   // 100/100
    {
        List<double> curent = Console.ReadLine().Split().Select(double.Parse).ToList();

        string command = Console.ReadLine();

        double average = curent.Average();

        for (int i = 0; i < curent.Count; i++)
        {
            if (curent[i] < average)
            {
                curent.Remove(curent[i]);
                i--;
            }
        }
        if (command == "Min")
        {
            Console.WriteLine(curent.Min());
        }
        else if (command == "Max")
        {
            Console.WriteLine(curent.Max());
        }
        else if (command == "All")
        {
            curent = curent.OrderBy(x => x).ToList();

            Console.WriteLine("{0}",string.Join(" ",curent));
        }
    }
}
