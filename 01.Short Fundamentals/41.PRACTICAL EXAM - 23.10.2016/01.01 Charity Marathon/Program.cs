using System;

internal class Program
{
    public static void Main() // 100/100
    {
        decimal days = decimal.Parse(Console.ReadLine());
        decimal runnerCount = decimal.Parse(Console.ReadLine());
        decimal averageNumber = decimal.Parse(Console.ReadLine());
        decimal lapLenght = decimal.Parse(Console.ReadLine());
        decimal trackCapacity = decimal.Parse(Console.ReadLine());
        decimal moneyPerKilimeter = decimal.Parse(Console.ReadLine());

        decimal moneyraised = Math.Min(runnerCount, trackCapacity * days) * averageNumber * lapLenght / 1000 * moneyPerKilimeter;

        Console.WriteLine("Money raised: {0:f2}", moneyraised);
    }
}