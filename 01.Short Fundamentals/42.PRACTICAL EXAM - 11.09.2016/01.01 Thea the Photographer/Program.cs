using System;
class TheaThePhotographer
{
    static void Main() // 100/100
    {
        int nPictures = int.Parse(Console.ReadLine());
        int filterSeconds = int.Parse(Console.ReadLine());
        int PercentUseful = int.Parse(Console.ReadLine());
        int secondsUpload = int.Parse(Console.ReadLine());

        long TimeFiltering = (long)nPictures * filterSeconds;
        int nUseful = (int)Math.Ceiling(nPictures * PercentUseful / 100d);

        long totalUpload = (long)secondsUpload * nUseful;

        long totalSec = TimeFiltering + totalUpload;
        long days = totalSec / 86400;
        long daysLeft = totalSec % 86400;
        long hours = daysLeft / 3600;
        long hoursLeft = daysLeft % 3600;
        long min = hoursLeft / 60;
        long sec = hoursLeft % 60;

        Console.WriteLine("{0}:{1:D2}:{2:D2}:{3:D2}", days, hours, min, sec);
    }
}