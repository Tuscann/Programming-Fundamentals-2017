using System;
using System.Linq;
public class Point
{
    public int X { get; set; }

    public int Y { get; set; }
}

public class Program
{
    public static void Main() // 100/100
    {
        int n = int.Parse(Console.ReadLine());
        Point[] points = new Point[n];

        for (int i = 0; i < n; i++)
        {
            Point currentPoint = ReadPoint();
            points[i] = currentPoint;
        }

        double minDistance = double.MaxValue;
        Point minDistanceFirst = new Point();
        Point minDistanceSecond = new Point();

        for (int first = 0; first < points.Length; first++)
        {
            for (int second = first + 1; second < points.Length; second++)
            {
                var distance = CalcDistance(points[first], points[second]);

                if (distance < minDistance)
                {
                    minDistance = distance;
                    minDistanceFirst = points[first];
                    minDistanceSecond = points[second];
                }
            }
        }

        Console.WriteLine($"{minDistance:f3}");
        Console.WriteLine($"({minDistanceFirst.X}, {minDistanceFirst.Y})");
        Console.WriteLine($"({minDistanceSecond.X}, {minDistanceSecond.Y})");

    }
    public static Point ReadPoint()
    {
        var pointAsString = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        Point point = new Point();
        point.X = pointAsString[0];
        point.Y = pointAsString[1];

        return point;
    }

    public static double CalcDistance(Point firstPoint, Point secondPoint)
    {
        double diffX = Math.Pow(firstPoint.X - secondPoint.X, 2);
        double diffY = Math.Pow(firstPoint.Y - secondPoint.Y, 2);
        double distance = Math.Sqrt(diffX + diffY);

        return distance;
    }
}