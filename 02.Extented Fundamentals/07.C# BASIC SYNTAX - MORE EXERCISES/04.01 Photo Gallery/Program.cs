using System;
class P04_PhotoGallery
{
    static void Main() // 100/100
    {
        string imageName = $"Name: DSC_{int.Parse(Console.ReadLine()):D4}.jpg";
        string dateTaken = $"Date Taken: {int.Parse(Console.ReadLine()):D2}/{int.Parse(Console.ReadLine()):D2}/{int.Parse(Console.ReadLine())} " +
                           $"{int.Parse(Console.ReadLine()):D2}:{int.Parse(Console.ReadLine()):D2}";
        double bytes = int.Parse(Console.ReadLine());
        int resolutionWidth = int.Parse(Console.ReadLine());
        int resolutionHeight = int.Parse(Console.ReadLine());

        Console.WriteLine(imageName);
        Console.WriteLine(dateTaken);
        string sizeName = "B";

        if (bytes > 1000)
        {
            bytes /= 1000;
            sizeName = "KB";
        }

        if (bytes > 1000)
        {
            bytes /= 1000;
            sizeName = "MB";
        }
        Console.WriteLine($"Size: {bytes}{sizeName}");

        if (resolutionHeight == resolutionWidth)
        {
            Console.WriteLine($"Resolution: {resolutionWidth}x{resolutionWidth} (square)");
        }
        else if (resolutionHeight > resolutionWidth)
        {
            Console.WriteLine($"Resolution: {resolutionWidth}x{resolutionHeight} (portrait)");
        }
        else
        {
            Console.WriteLine($"Resolution: {resolutionWidth}x{resolutionHeight} (landscape)");
        }
    }
}