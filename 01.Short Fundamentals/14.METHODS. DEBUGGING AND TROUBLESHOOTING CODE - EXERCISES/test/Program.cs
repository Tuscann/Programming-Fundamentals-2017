using System;
namespace problem19TheaThePhotographer
{
    class Problem19TheaThePhotographer
    {
        static void Main()
        {
            long pictures = long.Parse(Console.ReadLine());
            long timeForFilter = long.Parse(Console.ReadLine());
            long percentGodPictures = long.Parse(Console.ReadLine());
            long timeForUpload = long.Parse(Console.ReadLine());

            long filterTime = pictures * timeForFilter;
            long godPictures = (long)Math.Ceiling(pictures * percentGodPictures / 100.0);
            long timeUplouding = godPictures * timeForUpload;
            long totaltime = filterTime + timeUplouding;

            long day = totaltime / 86400;
            long cas = totaltime % 86400;
            long hours = cas / 3600;
            long min = cas % 3600;
            long minutes = min / 60;
            long sec = min % 60;
            Console.WriteLine($"{day}:{hours:D2}:{minutes:D2}:{sec:D2}");

        }
    }
}