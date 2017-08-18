using System;
public class P02_RectangleArea
{
    public static void Main() //100/100
    {
        double rectangleSideA = double.Parse(Console.ReadLine());
        double rectangleSideB = double.Parse(Console.ReadLine());

        double rectangleArea = rectangleSideA * rectangleSideB;

        Console.WriteLine("{0:F2}", rectangleArea);
    }
}