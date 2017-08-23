using System;
class Program
{
    static void Main() // 100/100
    {
        long picturesCount = int.Parse(Console.ReadLine());
        long filterTime = int.Parse(Console.ReadLine());
        long filterFactor = int.Parse(Console.ReadLine());
        long uploadTime = int.Parse(Console.ReadLine());

        var usefulPictures = (int)Math.Ceiling(picturesCount * (filterFactor / 100.0));
        long totalPictures = picturesCount * filterTime;
        long uploadedPictures = usefulPictures * uploadTime;
        long total = totalPictures + uploadedPictures;
        
        long secounds = 0;
        long minutes = 0;
        long hours = 0;
        long days = 0;
        
        secounds = total % 60;
        total = total - secounds;

        hours = total / 3600;

        minutes = total / 60 - hours * 60;

        days = hours / 24;

        hours = total / 3600 - days * 24;

        Console.WriteLine("{0}:{1}:{2}:{3}", days, hours.ToString("00"), minutes.ToString("00"), secounds.ToString("00"));
    }
}