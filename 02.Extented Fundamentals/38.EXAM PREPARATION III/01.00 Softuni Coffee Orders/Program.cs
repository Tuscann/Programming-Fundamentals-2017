using System;
using System.Globalization;

class Softuni_Coffee_Orders
{
    static void Main() // 100/100
    {
        int countOrders = int.Parse(Console.ReadLine());
        decimal totalExpenses = 0;
        for (int i = 0; i < countOrders; i++)
        {
            decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
            DateTime orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
            long countCapsules = long.Parse(Console.ReadLine());
            int daysInMonth = DateTime.DaysInMonth(orderDate.Year, orderDate.Month);
            decimal currentPrice = daysInMonth * countCapsules * pricePerCapsule;
            totalExpenses += currentPrice;
            Console.WriteLine($"The price for the coffee is: ${currentPrice:f2}");
        }
        Console.WriteLine($"Total: ${totalExpenses:f2}");
    }
}