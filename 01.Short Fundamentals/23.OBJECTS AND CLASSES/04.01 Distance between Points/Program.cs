using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] firstPointData = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[] secoundPointData = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int x1 = firstPointData[0]; int x2 = secoundPointData[0];
        int y1 = firstPointData[1]; int y2 = secoundPointData[1];

        double x = Math.Abs(x1 - x2);
        double y = Math.Abs(y1 - y2);

        double distance = Math.Sqrt(x * x + y * y);

        Console.WriteLine("Distance: {0:f3}", distance);
    }
}