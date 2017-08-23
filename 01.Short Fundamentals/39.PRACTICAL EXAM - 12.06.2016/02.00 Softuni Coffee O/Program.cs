using System;
using System.Globalization;
class Z2
{
    static void Main() // 100/100
    {
        decimal number = decimal.Parse(Console.ReadLine());
        decimal total = 0;

        for (decimal i = 0; i < number; i++)
        {
            decimal price = decimal.Parse(Console.ReadLine());
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
            decimal CountCapsules = decimal.Parse(Console.ReadLine());
            decimal days = DateTime.DaysInMonth(date.Year, date.Month);

            decimal curent = days * CountCapsules * price;
            Console.WriteLine("The price for the coffee is: ${0:f2}", curent);
            total = total + curent;
        }
        Console.WriteLine("Total: ${0:f2}", total);
    }
}