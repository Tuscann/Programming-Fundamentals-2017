using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main() // 100/100
    {
        var dic = new SortedDictionary<string, long>();

        while (true)
        {
            var curentRow = Console.ReadLine().Split().ToList();
            if (curentRow[0] == "Over")
            {
                break;
            }
            string firstElement = curentRow[0];
            string secondElement = curentRow[2];

            int value = 0;

            if (int.TryParse(firstElement, out value)) // is number
            {
                dic[secondElement] = value;
            }
            else
            {
                dic[firstElement] = long.Parse(secondElement);
            }
        }
        foreach (var row in dic)
        {
            Console.WriteLine("{0} -> {1}", row.Key, row.Value);
        }
    }
}