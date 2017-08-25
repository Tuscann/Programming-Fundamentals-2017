using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main() // 100/100
    {
        int n = int.Parse(Console.ReadLine());

        //List<Sale> sales = new List<Sale>();
        var salesByTown = new SortedDictionary<string, decimal>();

        for (int i = 0; i < n; i++)
        {
            Sale currentSale = new Sale().ReadSale();
            //sales.Add(currentSale);

            string nameOfTown = currentSale.Town;
            decimal currentTotalSum = currentSale.Price * currentSale.Quantity;

            if (!salesByTown.ContainsKey(nameOfTown))
            {
                salesByTown[nameOfTown] = 0m;
            }

            salesByTown[nameOfTown] += currentTotalSum;
        }

        foreach (var town in salesByTown)
        {
            Console.WriteLine($"{town.Key} -> {town.Value:f2}");
        }
    }
}

class Sale
{
    public string Town { get; set; }

    public string Product { get; set; }

    public decimal Price { get; set; }

    public decimal Quantity { get; set; }

    public Sale ReadSale()
    {
        string[] input = Console.ReadLine().Split(' ').ToArray();
        Sale sale = new Sale
        {
            Town = input[0],
            Product = input[1],
            Price = decimal.Parse(input[2]),
            Quantity = decimal.Parse(input[3])
        };

        return sale;
    }
}