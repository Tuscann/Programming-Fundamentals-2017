using System;
class Program
{
    static void Main()
    {
        long picsTaken = long.Parse(Console.ReadLine());
        long filterTime = long.Parse(Console.ReadLine());
        long percentage = long.Parse(Console.ReadLine());
        long uploadTime = long.Parse(Console.ReadLine());

        long amountFiltered = (long)Math.Ceiling(picsTaken * percentage / 100d);
        long filterAllPics = picsTaken * filterTime;
        long uploadAllPics = amountFiltered * uploadTime;
        long totalTime = filterAllPics + uploadAllPics;

        TimeSpan projectTime = TimeSpan.FromSeconds(totalTime);
        Console.WriteLine("{0:D1}:{1:D2}:{2:D2}:{3:D2}",
            projectTime.Days,
            projectTime.Hours,
            projectTime.Minutes,
            projectTime.Seconds);
    }
}