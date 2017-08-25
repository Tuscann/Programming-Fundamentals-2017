using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main() // 100/100
    {
        string pattern = @"^([A-Z][a-z]+):(\d+\.?\d{2}?)$";
        Regex regex = new Regex(pattern);
        var productData = new Dictionary<string, decimal>();

        string inputData = Console.ReadLine();

        while (inputData != "bill")
        {
            Match productInfo = regex.Match(inputData);

            if (productInfo.Success)
            {
                string productName = productInfo.Groups[1].Value;
                decimal price = decimal.Parse(productInfo.Groups[2].Value);

                if (!productData.ContainsKey(productName))
                {
                    productData.Add(productName, price);
                }

                productData[productName] = price;
            }

            inputData = Console.ReadLine();
        }

        foreach (var product in productData.OrderByDescending(p => p.Value))
        {
            Console.WriteLine($"{product.Key} costs {product.Value}");
        }
    }
}