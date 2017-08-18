using System;
class Program
{
    static void Main() // 100/100
    {
        int wingFlaps = int.Parse(Console.ReadLine());
        double distancePer1000wingFlaps = double.Parse(Console.ReadLine());
        int endurance = int.Parse(Console.ReadLine());

        double distance = Math.Abs(wingFlaps / 1000) * distancePer1000wingFlaps;

        int secondsFlaps = wingFlaps / 100;
        int secondsRests = wingFlaps / endurance * 5;
        int secondsPassed = secondsFlaps + secondsRests;

        Console.WriteLine($"{ distance:f2} m.");
        Console.WriteLine($"{secondsPassed} s.");
    }
}