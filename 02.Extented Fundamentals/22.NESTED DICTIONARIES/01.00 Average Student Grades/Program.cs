using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
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

            for (int index = 0; index < namee.Value.Count; index++)
            {
                Console.Write("{0:f2} ", namee.Value[index]);
            }
            Console.WriteLine("(avg: {0:f2})", namee.Value.Average());
        }
    }
}
