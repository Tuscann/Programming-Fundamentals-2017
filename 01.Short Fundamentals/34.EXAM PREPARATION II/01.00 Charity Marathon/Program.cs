using System;
class Program
{
    static void Main() // 100/100
    {
        decimal days = decimal.Parse(Console.ReadLine());
        decimal runners = decimal.Parse(Console.ReadLine());
        decimal avaregaLaps = decimal.Parse(Console.ReadLine());
        decimal lenght = decimal.Parse(Console.ReadLine());
        decimal capacityPerDay = decimal.Parse(Console.ReadLine());
        decimal moneyPerKilometers = decimal.Parse(Console.ReadLine());

        decimal cap = Math.Min(runners, capacityPerDay * days);
        
        decimal sum = cap * avaregaLaps * lenght / 1000 * moneyPerKilometers;
        Console.WriteLine("Money raised: {0:f2}", sum);
    }
}