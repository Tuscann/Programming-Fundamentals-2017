using System;
using System.Collections.Generic;
using System.Linq;
class Program
    {
        static void Main()
        {
            string products = Console.ReadLine();
            Dictionary<string, Dictionary<double, double>> result = new Dictionary<string, Dictionary<double, double>>();
            double totalAmount = 0.0;

            while (products != "stocked")
            {
                string[] product = products.Split().ToArray();
                string name = product[0];
                double price = double.Parse(product[1]);
                double quantity = double.Parse(product[2]);

                if (!result.ContainsKey(name)) // if key not exist create new dictionary
                {
                    result[name] = new Dictionary<double, double>();

                }
                if (!result[name].ContainsKey(price)) // if key exist value of neted dictionary 0
            {
                    result[name][price] = 0;
                }
                result[name][price] += quantity;  //increase value of nested dictionary quantity

            products = Console.ReadLine();
            }
            foreach (KeyValuePair<string, Dictionary<double, double>> namePriceQuantity in result)
            {
                string name = namePriceQuantity.Key;
                double price = namePriceQuantity.Value.Keys.Last();
                double quantity = namePriceQuantity.Value.Values.Sum();
                totalAmount += quantity * price;

                Console.WriteLine($"{name}: ${price:f2} * {quantity} = ${quantity * price:f2}");
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Grand Total: ${totalAmount:f2}");
        }
    }
