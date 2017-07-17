using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        Dictionary<string, List<double>> dic = new Dictionary<string, List<double>>();

        while (true)
        {
            List<string> curent = Console.ReadLine().Split().ToList();
            if (curent[0] == "stocked")
            {
                break;
            }
            string name = curent[0];
            double price = double.Parse(curent[1]);
            int quantity = int.Parse(curent[2]);
            
            if (!dic.ContainsKey(name))
            {
                dic[name] = new List<double>();
                dic[name].Add(0);
                dic[name].Add(0);
            }
            dic[name][0] = price;
            dic[name][1] += quantity;
        }
        double total = 0;
        foreach (KeyValuePair<string, List<double>> names in dic)
        {
            Console.WriteLine("{0}: ${1:F2} * {2} = ${3:F2}", names.Key, names.Value[0], names.Value[1], names.Value[0] * names.Value[1]);
            total += names.Value[0] * names.Value[1];
        }
        Console.WriteLine("{0}", string.Concat(Enumerable.Repeat("-", 30)));
        Console.WriteLine("Grand Total: ${0:F2}", total);
    }
}