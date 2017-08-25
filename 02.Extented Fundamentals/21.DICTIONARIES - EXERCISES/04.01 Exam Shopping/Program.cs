using System;
using System.Collections.Generic;
public class ExamShopping
{
    public static void Main() // 100/100
    {
        var shoppingCommand = Console.ReadLine();
        var productsInShop = new Dictionary<string, int>();

        while (shoppingCommand != "shopping time")
        {
            var itemsToStock = shoppingCommand.Split();
            var product = itemsToStock[1];
            var quantity = int.Parse(itemsToStock[2]);

            if (!productsInShop.ContainsKey(product))
            {
                productsInShop[product] = 0;
            }
            productsInShop[product] += quantity;

            shoppingCommand = Console.ReadLine();
        }
        shoppingCommand = Console.ReadLine();

        while (shoppingCommand != "exam time")
        {
            var itemsToBuy = shoppingCommand.Split();
            var product = itemsToBuy[1];
            var quantity = int.Parse(itemsToBuy[2]);

            if (!productsInShop.ContainsKey(product))
            {
                Console.WriteLine($"{product} doesn't exist");
            }
            else
            {
                if (productsInShop[product] == 0)
                {
                    Console.WriteLine($"{product} out of stock");
                }
                else
                {
                    productsInShop[product] -= quantity;

                    if (productsInShop[product] < 0)
                    {
                        productsInShop[product] = 0;
                    }
                }
            }
            shoppingCommand = Console.ReadLine();
        }
        foreach (var element in productsInShop)
        {
            var productName = element.Key;
            var quantityQuantity = element.Value;

            if (quantityQuantity > 0)
            {
                Console.WriteLine($"{productName} -> {quantityQuantity}");
            }
        }
    }
}