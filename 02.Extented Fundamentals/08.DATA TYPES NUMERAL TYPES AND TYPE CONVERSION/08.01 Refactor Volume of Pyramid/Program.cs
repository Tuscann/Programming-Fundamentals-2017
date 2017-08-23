using System;
public class RefactorVolumeofPyramid
{
    public static void Main() // 100/100
    {
        double lenght, width, hight = 0;
        Console.Write("Length: ");
        lenght = double.Parse(Console.ReadLine());
        Console.Write("Width: ");
        width = double.Parse(Console.ReadLine());
        Console.Write("Height: ");
        hight = double.Parse(Console.ReadLine());
        double volume = lenght * width * hight / 3;
        Console.WriteLine("Pyramid Volume: {0:F2}", volume);
    }
}