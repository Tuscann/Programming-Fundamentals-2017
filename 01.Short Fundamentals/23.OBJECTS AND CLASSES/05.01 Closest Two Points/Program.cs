using System;
using System.Collections.Generic;
class Program
{
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public string Print()
        {
            return $"({X}, {Y})";
        }
    }
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        List<Point> listPoint = new List<Point>();

        for (int i = 0; i < n; i++)
        {
            Point currentPoint = ReadPoint();
            listPoint.Add(currentPoint);
        }

        double smallestDistance = double.MaxValue;
        Point firstPointResult = null;
        Point secondPointResult = null;

        CalcClosestDistance(listPoint, ref smallestDistance, ref firstPointResult, ref secondPointResult);

        PrintPoints(smallestDistance, firstPointResult, secondPointResult);
    }

    private static void CalcClosestDistance(List<Point> listPoint, ref double smallestDistance, ref Point firstPointResult, ref Point secondPointResult)
    {
        for (int first = 0; first < listPoint.Count; first++)
        {
            for (int second = first + 1; second < listPoint.Count; second++)
            {
                Point firstPoint = listPoint[first];
                Point secondPoint = listPoint[second];
                double currentDistance = CalculteDistance(firstPoint, secondPoint);

                if (currentDistance < smallestDistance)
                {
                    smallestDistance = currentDistance;
                    firstPointResult = firstPoint;
                    secondPointResult = secondPoint;
                }
            }
        }
    }

    public static void PrintPoints(double smallestDistance, Point firstPointResult, Point secondPointResult)
    {
        Console.WriteLine($"{smallestDistance:f3}");
        Console.WriteLine(firstPointResult.Print());
        Console.WriteLine(secondPointResult.Print());
    }


    public static Point ReadPoint()
    {
        string[] pointParts = Console.ReadLine().Split(' ');

        Point pointCoordatinates = new Point
        {
            X = double.Parse(pointParts[0]),
            Y = double.Parse(pointParts[1])
        };
        return pointCoordatinates;
    }

    public static double CalculteDistance(Point firstPoint, Point secondPoint)
    {
        var hypotenuse = Math.Sqrt(Math.Pow(firstPoint.X - secondPoint.X, 2) + Math.Pow(firstPoint.Y - secondPoint.Y, 2));
        return hypotenuse;
    }
}