using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main() // 100/100
    {
        var dic = new Dictionary<string, Dictionary<string, decimal>>();

        while (true)
        {
            string xs = Console.ReadLine();
            if (xs == "end")
            {
                break;
            }
            List<string> curent = xs.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToList();

            string bank = curent[0];
            string name = curent[1];
            decimal price = decimal.Parse(curent[2]);

            if (!dic.ContainsKey(bank))
            {
                dic[bank] = new Dictionary<string, decimal>();
            }
            if (!dic[bank].ContainsKey(name))
            {
                dic[bank].Add(name, 0);
            }
            dic[bank][name] += price;
        }
        foreach (var bank in dic.OrderByDescending(x => x.Value.Values.Sum()).ThenByDescending(x => x.Value.Values.Max()).ToDictionary(x => x.Key, x => x.Value))
        {
            foreach (var name in bank.Value.OrderByDescending(x => x.Value))
            {
                Console.WriteLine("{0} -> {1} ({2})", name.Key, name.Value, bank.Key);
            }
        }
    }
}