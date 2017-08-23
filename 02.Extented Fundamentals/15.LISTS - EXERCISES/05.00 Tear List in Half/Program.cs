using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()  // 100/100
    {
        List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        List<int> news = input.Skip(input.Count / 2).ToList();

        for (int i = 0; i < news.Count; i++)
        {
            Console.Write(news[i] / 10 + " " + input[i] + " " + news[i] % 10 + " ");
        }
    }
}