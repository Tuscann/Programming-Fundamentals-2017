using System;
class Program
{
    static void Main()  // 100/100
    {
        double point1X1 = double.Parse(Console.ReadLine());
        double point1Y1 = double.Parse(Console.ReadLine());
        double point1X2 = double.Parse(Console.ReadLine());
        double point1Y2 = double.Parse(Console.ReadLine());

        double point2X1 = double.Parse(Console.ReadLine());
        double point2Y1 = double.Parse(Console.ReadLine());
        double point2X2 = double.Parse(Console.ReadLine());
        double point2Y2 = double.Parse(Console.ReadLine());

        double first = LongestLine(point1X1, point1Y1, point1X2, point1Y2);
        double secound = LongestLine(point2X1, point2Y1, point2X2, point2Y2);

        if (first >= secound)
        {
            ClosestPoint(point1X1, point1Y1, point1X2, point1Y2);
        }
        else
        {
            ClosestPoint(point2X1, point2Y1, point2X2, point2Y2);
        }
    }
    static double LongestLine(double x1, double y1, double x2, double y2)
    {
        double sum = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
        return sum;
    }
    static void ClosestPoint(double x1, double y1, double x2, double y2)
    {
        double first = Math.Sqrt(Math.Pow(y1, 2) + Math.Pow(x1, 2));
        double secound = Math.Sqrt(Math.Pow(y2, 2) + Math.Pow(x2, 2));

        if (first <= secound)
        {
            Console.WriteLine("({0}, {1})({2}, {3})", x1, y1, x2, y2);
        }
        else
        {
            Console.WriteLine("({0}, {1})({2}, {3})", x2, y2, x1, y1);
        }
    }
}