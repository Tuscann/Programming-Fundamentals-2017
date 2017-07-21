using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()  // 100/100
    {
        var dic = new Dictionary<string, Dictionary<string, int>>();

        while (true)
        {
            string x = Console.ReadLine();
            if (x == "end")
            {
                break;
            }
            var current = x.Split().ToList();

            string nameOfThePerson = current[0];
            string camperModel = current[1];
            int nightToStay = int.Parse(current[2]);

            if (!dic.ContainsKey(nameOfThePerson))
            {
                dic[nameOfThePerson] = new Dictionary<string, int>();
            }
            dic[nameOfThePerson].Add(camperModel, nightToStay);

        }
        foreach (var name in dic.OrderByDescending(c => c.Value.Count).ThenBy(p => p.Key.Length))
        {
            Console.WriteLine("{0}: {1}", name.Key, name.Value.Count);

            foreach (var model in name.Value)
            {
                Console.WriteLine("***{0}", model.Key);
            }
            Console.WriteLine("Total stay: {0} nights", name.Value.Values.Sum());
        }
    }
}