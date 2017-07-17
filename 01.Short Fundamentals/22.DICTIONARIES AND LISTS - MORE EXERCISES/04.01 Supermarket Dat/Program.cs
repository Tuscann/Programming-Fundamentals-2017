using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        Dictionary<string, Dictionary<string, decimal>> theShop = new Dictionary<string, Dictionary<string, decimal>>();

        string[] inputLine = Console.ReadLine().Split(' ');

        while (inputLine[0] != "stocked")
        {
            string product = inputLine[0];
            decimal price = decimal.Parse(inputLine[1]);
            decimal quantity = decimal.Parse(inputLine[2]);

            if (!theShop.ContainsKey(product))
            {
                theShop[product] = new Dictionary<string, decimal>();
                theShop[product]["Price"] = 0;
                theShop[product]["Quantity"] = 0;
            }
            theShop[product]["Price"] = price;
            theShop[product]["Quantity"] += quantity;

            inputLine = Console.ReadLine().Split(' ');
        }
        decimal grandTotal = 0;

        foreach (KeyValuePair<string, Dictionary<string, decimal>> outerKvp in theShop)
        {
            string productName = outerKvp.Key;

            Dictionary<string, decimal> priceQuantity = outerKvp.Value;

            decimal currentPrice = priceQuantity["Price"];

            decimal currentQuantity = priceQuantity["Quantity"];

            decimal totalPrice = currentPrice * currentQuantity;

            grandTotal += totalPrice;

            Console.WriteLine($"{productName}: ${currentPrice:f2} * {currentQuantity} = ${totalPrice:f2}");
        }
        Console.WriteLine(new string('-', 30));
        Console.WriteLine($"Grand Total: ${grandTotal:f2}");
    }
}