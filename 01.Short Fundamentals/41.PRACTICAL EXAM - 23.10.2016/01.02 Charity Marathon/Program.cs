using System;
class Program
{
    static void Main() // 100/100
    {
        int days = int.Parse(Console.ReadLine());
        int runners = int.Parse(Console.ReadLine());
        int lapsPerRunner = int.Parse(Console.ReadLine());
        int lapLength = int.Parse(Console.ReadLine());
        int trackCapacity = int.Parse(Console.ReadLine());
        decimal moneyPerKm = decimal.Parse(Console.ReadLine());

        trackCapacity = trackCapacity * days;
        runners = Math.Min(trackCapacity, runners);
        long totalMeters = (long)runners * lapLength * lapsPerRunner;
        long totalKm = totalMeters / 1000;
        decimal totalMoney = totalKm * moneyPerKm;

        Console.WriteLine($"Money raised: {totalMoney:f2}");
    }
}