using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        List<string> input = Console.ReadLine().Split(' ').ToList();

        long sum = 0;

        foreach (string strings in input)
        {
            char[] charArray = strings.ToCharArray();
            Array.Reverse(charArray);
            string stringToBeInteger = new string(charArray);
            sum += int.Parse(stringToBeInteger);
        }
        Console.WriteLine(sum);
    }
}