using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main() // 100/100
    {
        var dic = new Dictionary<string, int>();

        while (true)
        {
            var current = Console.ReadLine().Split().ToList();
            if (current[0] + current[1] == "shoppingtime")
            {
                break;
            }
            if (current[0] == "stock")
            {
                string product = current[1];
                int quantity = int.Parse(current[2]);

                if (dic.ContainsKey(product))
                {
                    dic[product] += quantity;
                }
                if (!dic.ContainsKey(product))
                {
                    dic[product] = quantity;
                }
            }
        }
        while (true)
        {
            var remove = Console.ReadLine().Split().ToList();
            if (remove[0] + remove[1] == "examtime")
            {
                break;
            }
            if (remove[0] == "buy")
            {
                string product = remove[1];
                int quantity = int.Parse(remove[2]);

                if (!dic.ContainsKey(product))
                {
                    Console.WriteLine("{0} doesn't exist", product);
                }
                if (dic.ContainsKey(product))
                {
                    if (dic[product] == 0)
                    {
                        Console.WriteLine("{0} out of stock", product);
                    }
                    else
                    {
                        if (dic[product] < quantity)
                        {
                            dic[product] = 0;
                        }
                        else
                        {
                            dic[product] -= quantity;
                        }
                    }
                }
            }
        }
        foreach (var row in dic)
        {
            if (row.Value > 0)
            {
                Console.WriteLine("{0} -> {1}", row.Key, row.Value);
            }
        }
    }
}