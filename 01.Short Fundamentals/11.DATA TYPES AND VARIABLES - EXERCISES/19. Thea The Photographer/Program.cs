using System;
class Program
{
    static void Main()
    {
        long picsTaken, filterTime, percentage, uploadTime, amountFiltered, filterAllPics, uploadAllPics, totalTime, seconds, minutes, hours, days;

        picsTaken = long.Parse(Console.ReadLine());
        filterTime = long.Parse(Console.ReadLine());
        percentage = long.Parse(Console.ReadLine());
        uploadTime = long.Parse(Console.ReadLine());

        amountFiltered = (long)Math.Ceiling(picsTaken * percentage / 100d);
        filterAllPics = picsTaken * filterTime;
        uploadAllPics = amountFiltered * uploadTime;
        totalTime = filterAllPics + uploadAllPics;

        seconds = totalTime % 60;
        minutes = (totalTime - seconds) / 60 % 60;
        hours = (totalTime - seconds - minutes * 60) /3600;
        days = (totalTime - seconds - minutes * 60 - hours * 360) / 86400;

        Console.WriteLine($"{days:d1}:{hours:d2}:{minutes}:{seconds:d2}");
    }
}