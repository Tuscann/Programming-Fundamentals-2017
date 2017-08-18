using System;
class P03_Megapixels
{
    static void Main() // 100/100
    {
        int resolutionWidth = int.Parse(Console.ReadLine());
        int resolutionHeight = int.Parse(Console.ReadLine());

        double megapixels = Math.Round(resolutionWidth * resolutionHeight / 1000000.0, 1);
        Console.WriteLine($"{resolutionWidth}x{resolutionHeight} => {megapixels}MP");
    }
}