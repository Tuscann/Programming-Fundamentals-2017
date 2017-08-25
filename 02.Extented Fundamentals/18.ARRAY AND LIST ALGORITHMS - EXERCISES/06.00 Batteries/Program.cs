using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main() // 100/100
    {
        List<double> capacities = Console.ReadLine().Split().Select(double.Parse).ToList();
        List<double> usagePerHour = Console.ReadLine().Split().Select(a => double.Parse(a)).ToList();

        double hours = int.Parse(Console.ReadLine());

        for (int i = 0; i < capacities.Count; i++)
        {
            double leftCapacity = capacities[i] - usagePerHour[i] * hours;
            if (leftCapacity  > 0)
            {
                double oneProsent = capacities[i] / 100.0;
                double xi = leftCapacity  / oneProsent;

                Console.WriteLine("Battery {0}: {1:f2} mAh ({2:f2})%", i+1, leftCapacity , xi);
            }
            else
            {
                double latest = capacities[i] / usagePerHour[i];

                if (capacities[i] % usagePerHour[i] > 0)
                {
                    latest++;
                }
                Console.WriteLine("Battery {0}: dead (lasted {1} hours)", i+1, (int)latest);
            }
        }
    }
}