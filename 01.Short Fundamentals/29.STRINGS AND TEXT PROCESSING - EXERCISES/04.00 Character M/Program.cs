using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        List<string> input = Console.ReadLine().Split().ToList();

        string first = input[0];
        string secoound = input[1];
        int sum = 0;

        for (int i = 0; i < Math.Min(first.Length, secoound.Length); i++)
        {
            sum += first[i] * secoound[i];
        }
        if (first.Length != secoound.Length)
        {
            if (first.Length > secoound.Length)
            {
                int take = first.Length - secoound.Length;
                string strings = first.Substring(secoound.Length, take);
                int stringSum = strings.Sum(p => Convert.ToInt32(p));
                sum += stringSum;
            }
            if (first.Length < secoound.Length)
            {
                int take = secoound.Length - first.Length;
                string strings = secoound.Substring(first.Length, take);


                int stringSum = strings.Sum(p => Convert.ToInt32(p));
                sum += stringSum;
            }
        }
        Console.WriteLine(sum);
    }
}