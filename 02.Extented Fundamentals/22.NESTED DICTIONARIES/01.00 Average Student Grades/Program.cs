using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main() // 100/100
    {
        Dictionary<string, List<double>> dic = new Dictionary<string, List<double>>();
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            List<string> curent = Console.ReadLine().Split().ToList();

            string name = curent[0];
            double grade = double.Parse(curent[1]);

            if (dic.ContainsKey(name))
            {
                dic[name].Add(grade);
            }

            if (!dic.ContainsKey(name))
            {
                dic[name] = new List<double>();
                dic[name].Add(grade);
            }
        }
        foreach (KeyValuePair<string, List<double>> namee in dic)
        {
            Console.Write("{0} -> ", namee.Key);

            foreach (double t in namee.Value)
            {
                Console.Write("{0:f2} ", t);
            }
            Console.WriteLine("(avg: {0:f2})", namee.Value.Average());
        }
    }
}