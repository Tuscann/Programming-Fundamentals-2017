using System;
using System.Linq;
class Program
{
    static void Main() // 100/100
    {
        var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int minvalue = Int32.MaxValue;

        foreach (int t in input)
        {
            if (t < minvalue)
            {
                minvalue = t;
            }
        }
        Console.WriteLine(minvalue);
    }
}