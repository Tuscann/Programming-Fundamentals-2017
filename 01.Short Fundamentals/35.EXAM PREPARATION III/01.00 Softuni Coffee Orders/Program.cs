using System;
using System.Globalization;
class E01_SoftuniCoffeeOrders
{
    static void Main() // 100/100
    {
        int ordersCount = int.Parse(Console.ReadLine());
        decimal totalPrice = 0;

        for (int i = 0; i < ordersCount; i++)
        {
            decimal capsulePrice = decimal.Parse(Console.ReadLine());
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
            int capsuleCount = int.Parse(Console.ReadLine());

            int daysInMonth = DateTime.DaysInMonth(date.Year, date.Month);

            decimal currentPrice = capsulePrice * capsuleCount * daysInMonth;

            Console.WriteLine($"The price for the coffee is: ${currentPrice:f2}");
            totalPrice += currentPrice;
        }

        Console.WriteLine($"Total: ${totalPrice:f2}");
    }
}