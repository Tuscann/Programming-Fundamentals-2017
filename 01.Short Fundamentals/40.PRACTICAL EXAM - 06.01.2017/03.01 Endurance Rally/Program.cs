using System;
using System.Linq;
using System.Text.RegularExpressions;
class Program
{
    static void Main() // 100/100
    {
        string[] players = Regex.Split(Console.ReadLine(), @"\s+");
        double[] route = Regex.Split(Console.ReadLine(), @"\s+").Select(p => double.Parse(p) * -1).ToArray();
        long[] checkpointIndexes = Regex.Split(Console.ReadLine(), @"\s+").Where(t => t.Length > 0).Select(long.Parse).Distinct().ToArray();

        foreach (long i in checkpointIndexes)
        {
            if (i >= 0 && i < route.Length)
            {
                route[i] *= -1;
            }
        }
        foreach (string p in players)
        {
            double fuel = p[0];
            int index = 0;
            foreach (double r in route)
            {
                fuel += r;
                if (fuel <= 0)
                {
                    Console.WriteLine("{0} - reached {1}", p, index);
                    break;
                }
                index++;
            }
            if (fuel > 0)
            {
                Console.WriteLine("{0} - fuel left {1:F2}", p, fuel);
            }
        }
    }
}