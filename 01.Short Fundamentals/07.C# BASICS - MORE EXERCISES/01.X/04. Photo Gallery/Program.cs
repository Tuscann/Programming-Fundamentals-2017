using System;
class Program
{
    static void Main()
    {
        int photoUmber = int.Parse(Console.ReadLine());
        int day = int.Parse(Console.ReadLine());
        string month = Console.ReadLine();
        int year = int.Parse(Console.ReadLine());
        string hours = Console.ReadLine();
        string minutes = Console.ReadLine();
        decimal bytes = decimal.Parse(Console.ReadLine());
        int width = int.Parse(Console.ReadLine()); 
        int height = int.Parse(Console.ReadLine());
        
        string printedbytes="";

        if (bytes < 1000)
        {
            printedbytes = bytes + "B";
        }
        else if (bytes < 1000000)
        {
            bytes /= 1000;
            printedbytes = bytes + "KB";
        }
        else
        {
            bytes /= 1000000;
            printedbytes= bytes + "MB";
        }

        string oriention = "square";
        if (width > height)
        {
            oriention = "landscape";
        }
        else if (width < height)
        {
            oriention = "portrait";
        }

        Console.WriteLine("Name: DSC_{0}.jpg", photoUmber.ToString("D4"));
        Console.WriteLine("Date Taken: {0:d2}/{1}/{2} {3}:{4}", day, month.PadLeft(2, '0'), year, hours.PadLeft(2, '0'), minutes.PadLeft(2, '0'));
        Console.WriteLine("Size: {0}", printedbytes);
        Console.WriteLine("Resolution: {0}x{1} ({2})", width, height, oriention);
    }
}