using System;
using System.Linq;
class Program
{
    static void Main()
    {
        decimal number = decimal.Parse(Console.ReadLine());
        ;
        string x = number.ToString();

        if (x.Contains('.'))
        {
            Console.WriteLine("Rainy");
        }
        else if (sbyte.MinValue <= number && number <= sbyte.MaxValue)
        {
            Console.WriteLine("Sunny");
        }
        else if (int.MinValue <= number && number <= int.MaxValue)
        {
            Console.WriteLine("Cloudy");
        }
        else if (long.MinValue <= number && number <= long.MaxValue)
        {
            Console.WriteLine("Windy");
        }
    }
}