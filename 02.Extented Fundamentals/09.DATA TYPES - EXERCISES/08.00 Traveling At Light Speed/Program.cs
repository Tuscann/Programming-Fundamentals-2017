using System;
class LightSpeedTravel_3
{
    static void Main() // 100/100
    {
        double lightYears = double.Parse(Console.ReadLine());
        double totalKilometers = lightYears * 9450000000000;
        double totalSeconds = totalKilometers / 300000;

        TimeSpan convertion = TimeSpan.FromSeconds(totalSeconds);
        string formatWeeks = string.Format("{0} weeks", convertion.Days / 7);
        string formatDays = string.Format("{0} days", convertion.Days % 7);
        string formatHours = string.Format("{0} hours", convertion.Hours);
        string formatMinutes = string.Format("{0} minutes", convertion.Minutes);
        string formatSeconds = string.Format("{0} seconds", convertion.Seconds);

        Console.WriteLine(formatWeeks);
        Console.WriteLine(formatDays);
        Console.WriteLine(formatHours);
        Console.WriteLine(formatMinutes);
        Console.WriteLine(formatSeconds);
    }
}