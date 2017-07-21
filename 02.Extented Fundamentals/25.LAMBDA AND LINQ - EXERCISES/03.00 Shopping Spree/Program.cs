using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()  // 100/100
    {
        decimal budjet = decimal.Parse(Console.ReadLine());

        Dictionary<string, decimal> dic = new Dictionary<string, decimal>();


        while (true)
        {
            string x = Console.ReadLine();
            if (x == "end")
            {
                break;
            }
            string[] current = x.Split();

            string productName = current[0];
            decimal price = decimal.Parse(current[1]);

            if (!dic.ContainsKey(productName))
            {
                dic[productName] = price;

            }
            if (dic.ContainsKey(productName))
            {
                if (dic[productName] > price)
                {
                    dic[productName] = price;
                }
            }
        }
        dic = dic.OrderByDescending(x => x.Value).ThenBy(x => x.Key.Length).ToDictionary(x => x.Key, x => x.Value);

        if (budjet >= dic.Values.Sum())
        {
            foreach (KeyValuePair<string, decimal> product in dic)
            {
                Console.WriteLine("{0} costs {1:f2}", product.Key, product.Value);
            }
        }
        else
        {
            Console.WriteLine("Need more money... Just buy banichka");
        }
    }
}