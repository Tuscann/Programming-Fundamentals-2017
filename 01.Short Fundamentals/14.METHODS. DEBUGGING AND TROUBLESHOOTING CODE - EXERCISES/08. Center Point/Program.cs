using System;
class Program  // 100/100
{
    static void ClosestPoint(double x1, double y1, double x2, double y2)
    {
        double first = Math.Sqrt(Math.Pow(y1, 2) + Math.Pow(x1, 2));
        double secound = Math.Sqrt(Math.Pow(y2, 2) + Math.Pow(x2, 2));

        if (first < secound)
        {
            Console.WriteLine("({0}, {1})", x1, y1);
        }
        else
        {
            Console.WriteLine("({0}, {1})", x2, y2);
        }
    }
    static void Main()
    {
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());

        ClosestPoint(x1, y1, x2, y2);
    }
}