using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        List<string> input = Console.ReadLine().Split().ToList();
        Dictionary<string, int> dic = new Dictionary<string, int>();

        for (int i = 0; i < input.Count; i++)
        {
            if (dic.ContainsKey(input[i]))
            {
                dic[input[i]]++;
            }
            if (!dic.ContainsKey(input[i]))
            {
                dic[input[i]] = 1;
            }
        }
        dic = dic.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

        double sum = dic.Values.Sum();

        foreach (KeyValuePair<string, int> row in dic)
        {
            double persentage = 100 / sum * row.Value;

            Console.WriteLine("{0} -> {1} times ({2:f2}%)", row.Key, row.Value, persentage);
        }
    }
}