using System;
using System.Collections.Generic;
using System.Linq;
public class MostValuedCustomer  // 100/100
{
    public static Dictionary<string, double> Products = new Dictionary<string, double>();
    public static Dictionary<string, Dictionary<string, double>> Users = new Dictionary<string, Dictionary<string, double>>();

    public static void Main()
    {
        UntillShopIsClosedReadFrom(Console.ReadLine());
        ReadComandsUntillPrintFrom(Console.ReadLine());
        CalculateAllProductsByGivenPrice();
        PrintWhoIsBiggerSpender();
    }

    static void PrintWhoIsBiggerSpender()
    {
        var biggerSpender = TakeBiggerSpender();
        Console.WriteLine($"Biggest spender: {biggerSpender.First().Key}");
        Console.WriteLine($"^Products bought:");
        foreach (var user in biggerSpender)
        {
            foreach (var item in user.Value.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"^^^{item.Key}: {item.Value:F2}");
            }
        }
        var totalSum = Users.OrderByDescending(x => x.Value.Values.Sum()).First().Value.Values.Sum();
        Console.WriteLine($"Total: {totalSum:F2}");

    }

    static Dictionary<string, Dictionary<string, double>> TakeBiggerSpender()
    {
        var bigger = new Dictionary<string, Dictionary<string, double>>();
        var user = string.Empty;
        foreach (var item in Users.OrderByDescending(x => x.Value.Values.Sum()))
        {
            user = item.Key;
            break;
        }
        bigger[user] = new Dictionary<string, double>();
        foreach (var item in Users.OrderByDescending(x => x.Value.Values.Sum()).First().Value)
        {
            bigger[user][item.Key] = Products[item.Key];
        }
        return bigger;
    }

    static void CalculateAllProductsByGivenPrice()
    {
        var userKeys = Users.Keys.ToArray();
        for (int i = 0; i < userKeys.Length; i++)
        {
            var valueKeys = Users[userKeys[i]].Keys.ToArray();
            CalculateCurentUser(userKeys[i], valueKeys);
        }
    }

    static void CalculateCurentUser(string name, string[] product)
    {
        for (int i = 0; i < product.Length; i++)
        {
            Users[name][product[i]] *= Products[product[i]];
        }
    }

    static void UntillShopIsClosedReadFrom(string unsplited)
    {
        if (unsplited != "Shop is open")
        {
            SplitAndAddToProductCollection(unsplited);
            UntillShopIsClosedReadFrom(Console.ReadLine());
        }
    }

    static void SplitAndAddToProductCollection(string unsplited)
    {
        var splited = unsplited.Split();
        var productName = splited.First();
        var productPrice = Convert.ToDouble(splited.Last());
        ProductsAdd(productName, productPrice);
    }

    static void ProductsAdd(string productName, double productPrice)
    {
        if (!Products.ContainsKey(productName))
        {
            Products[productName] = 0;
        }
        Products[productName] = productPrice;
    }

    static void ReadComandsUntillPrintFrom(string unsplited)
    {
        if (unsplited != "Print")
        {
            if (unsplited == "Discount")
            {
                DecreaseFirstThreeExpensive();
            }
            else
            {
                SplitAndAddToUsers(unsplited);
            }
            ReadComandsUntillPrintFrom(Console.ReadLine());
        }

    }

    static void DecreaseFirstThreeExpensive()
    {
        var expensives = TakeFirstThree();
        for (int index = 0; index < expensives.Length; index++)
        {
            var key = expensives[index];
            Products[key] = Products[key] * 0.9;
        }
    }

    static string[] TakeFirstThree()
    {
        Products = Products.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
        return Products.Keys.Take(3).ToArray();
    }

    static void SplitAndAddToUsers(string unsplited)
    {
        var splited = unsplited.Split(new[] { ": ", ", " }, StringSplitOptions.RemoveEmptyEntries);
        var name = splited.First();
        var products = splited.Skip(1).ToArray();
        UsersAdd(name, products);
    }

    static void UsersAdd(string name, string[] collection)
    {
        if (!Users.ContainsKey(name))
        {
            Users[name] = new Dictionary<string, double>();
        }
        foreach (var item in collection)
        {
            if (Products.ContainsKey(item))
            {
                if (!Users[name].ContainsKey(item))
                {
                    Users[name][item] = 0;
                }
                Users[name][item]++;
            }
        }
    }
}