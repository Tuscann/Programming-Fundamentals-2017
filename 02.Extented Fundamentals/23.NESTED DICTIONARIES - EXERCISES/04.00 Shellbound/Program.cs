using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()  //100/100
    {
        var dic = new Dictionary<string, List<int>>();

        while (true)
        {
            var curent = Console.ReadLine().Split();
            if (curent[0] == "Aggregate")
            {
                break;
            }
            string city = curent[0];
            int shellSize = int.Parse(curent[1]);

            if (!dic.ContainsKey(city))
            {
                dic[city] = new List<int>();
            }
            if (!dic[city].Contains(shellSize))
            {
                dic[city].Add(shellSize);
            }
        }
        foreach (var city in dic)
        {
            Console.WriteLine("{0} -> {1} ({2})", city.Key, string.Join(", ", city.Value), Math.Ceiling(city.Value.Sum() - city.Value.Average()));
        }
    }
}