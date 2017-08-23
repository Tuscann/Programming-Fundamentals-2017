using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main() // 100/100
    {
        string[] drivers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        double[] zones = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

        List<int> checkpoints = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
        
        foreach (string driver in drivers)
        {
            bool outOfFuel = false;
            int reachedIndex = 0;
            double fuel = driver[0];

            for (int zoneIndex = 0; zoneIndex < zones.Length; zoneIndex++)
            {
                if (checkpoints.Contains(zoneIndex))
                {
                    fuel += zones[zoneIndex];
                }
                else
                {
                    fuel -= zones[zoneIndex];
                }

                if (fuel <= 0)
                {
                    outOfFuel = true;
                    reachedIndex = zoneIndex;
                    break;
                }
            }

            if (outOfFuel == true)
            {
                Console.WriteLine($"{driver} - reached {reachedIndex}");
            }
            else
            {
                Console.WriteLine("{0} - fuel left {1:F2}", driver, fuel);
            }
        }
    }
}