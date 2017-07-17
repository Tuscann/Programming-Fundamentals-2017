using System;
using System.Linq;
class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int minvalue = Int32.MaxValue;

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] < minvalue)
            {
                minvalue = input[i];
            }
        }
        Console.WriteLine(minvalue);
    }
}