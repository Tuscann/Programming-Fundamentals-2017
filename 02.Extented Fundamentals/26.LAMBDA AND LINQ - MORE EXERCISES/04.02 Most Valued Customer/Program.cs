using System;
using System.Collections.Generic;
using System.Linq;
class MostValuedCustomer
{
    static void Main()  // 100/100
    {
        Dictionary<string, double> productsData = new Dictionary<string, double>();
        Dictionary<string, List<string>> customerData = new Dictionary<string, List<string>>();

        string input = Console.ReadLine();
        while (input != "Shop is open")
        {
            string[] inputTokens = input.Split(' ');
            string product = inputTokens[0];
            double price = double.Parse(inputTokens[1]);

            productsData[product] = price;

            input = Console.ReadLine();
        }

        input = Console.ReadLine();
        while (input != "Print")
        {
            string[] inputTokens = input.Split(new string[] { ": ", ", " },StringSplitOptions.RemoveEmptyEntries);

            if (inputTokens[0] == "Discount")
            {
                IEnumerable<KeyValuePair<string, double>> discountedProducts = productsData
                    .OrderByDescending(pd => pd.Value)
                    .Take(3)
                    .Select(pd =>
                        new KeyValuePair<string, double>(pd.Key, pd.Value * 0.9));

                foreach (KeyValuePair<string, double> discountedProduct in discountedProducts)
                {
                    productsData[discountedProduct.Key] = discountedProduct.Value;
                }
            }
            else
            {
                string customer = inputTokens[0];
                if (!customerData.ContainsKey(customer))
                {
                    customerData.Add(customer, new List<string>());
                }

                for (int index = 1; index < inputTokens.Length; index++)
                {
                    string boughtProduct = inputTokens[index];

                    if (productsData.ContainsKey(boughtProduct))
                    {
                        customerData[customer].Add(boughtProduct);
                    }
                }
            }

            input = Console.ReadLine();
        }

        KeyValuePair<string, List<string>> topCustomer = customerData
            .OrderByDescending(d => d.Value.Sum(product => productsData[product]))
            .First();

        string name = topCustomer.Key;
        List<string> productsBought = topCustomer.Value;
        Console.WriteLine("Biggest spender: {0}", name);
        Console.WriteLine("^Products bought:");

        double total = productsBought.Sum(p => productsData[p]);

        IOrderedEnumerable<string> orderedProducts = productsBought.Distinct().OrderByDescending(p => productsData[p]);

        foreach (string product in orderedProducts)
        {
            Console.WriteLine("^^^{0}: {1:F2}", product, productsData[product]);
        }

        Console.WriteLine("Total: {0:F2}", total);
    }
}