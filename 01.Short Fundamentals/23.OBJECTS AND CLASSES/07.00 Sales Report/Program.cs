using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        List<Sale> sales = new List<Sale>();
        int numberOfSalse = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfSalse; i++)
        {
            string[] saleParameters = Console.ReadLine().Split();
            Sale sale = new Sale()
            {
                Town = saleParameters[0],
                Product = saleParameters[1],
                Price = decimal.Parse(saleParameters[2]),
                Quantity = double.Parse(saleParameters[3])
            };
            sales.Add(sale);
        }
        List<string> towns = sales.Select(x => x.Town).Distinct().OrderBy(x => x).ToList();

        foreach (var town in towns)
        {
            decimal townRevenue = sales.Where(sale => sale.Town == town).Select(sale => sale.Revenue()).Sum();
            Console.WriteLine("{0} -> {1:f2}", town, townRevenue);
        }
    }
}

class Sale
{
    public string Town { get; set; }
    public string Product { get; set; }
    public decimal Price { get; set; }
    public double Quantity { get; set; }

    public decimal Revenue()
    {
        return Price * (decimal)Quantity;
    }
}


