using System;
using System.Collections.Generic;
using System.Linq;
class ShoppingSpree
{
    static void Main() // 100/100
    {
        Dictionary<string, double> products = new Dictionary<string, double>();
        double budget = double.Parse(Console.ReadLine());
        string input = Console.ReadLine();
        double sum = 0;

        while (input != "end")
        {
            string[] tokens = input.Split(' ');
            string productName = tokens[0];
            double productPrice = double.Parse(tokens[1]);

            if (products.ContainsKey(productName))
            {
                if (products[productName] > productPrice)
                {
                    products[productName] = productPrice;
                }
            }
            else
            {
                products[productName] = productPrice;
            }

            input = Console.ReadLine();
        }

        Dictionary<string, double> sortedProducts =
            products
                .OrderByDescending(p => p.Value)
                .ThenBy(n => n.Key.Length)
                .ToDictionary(k => k.Key, v => v.Value);

        foreach (double price in sortedProducts.Values)
        {
            sum += price;
        }

        if (sum > budget)
        {
            Console.WriteLine("Need more money... Just buy banichka");
        }
        else
        {
            foreach (KeyValuePair<string, double> item in sortedProducts)
            {
                string productName = item.Key;
                double productPrice = item.Value;

                Console.WriteLine($"{productName} costs {productPrice:f2}");
            }
        }
    }
}