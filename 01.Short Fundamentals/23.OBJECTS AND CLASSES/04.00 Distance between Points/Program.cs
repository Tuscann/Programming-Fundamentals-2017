using System;
using System.Linq;
class Point
{
    public double X { get; set; }
    public double Y { get; set; }
}
class Program
{
    static void Main()
    {
        int[] first = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[] secound = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        Point firstPoint = new Point { X = first[0], Y = first[1] };
        Point secoundPoint = new Point { X = secound[0], Y = secound[1] };

        double distance = CalcDistance(firstPoint, secoundPoint);

        Console.WriteLine("{0:f3}", distance);
    }
    public static double CalcDistance(Point firstPoint, Point secondPoint)
    {
        var hypotenuse = Math.Sqrt(Math.Pow(firstPoint.X - secondPoint.X, 2) + Math.Pow(firstPoint.Y - secondPoint.Y, 2));
        return hypotenuse;
    }
}