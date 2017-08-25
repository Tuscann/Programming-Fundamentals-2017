using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main() // 100/100
    {
        List<decimal> capacity = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
        List<decimal> usage = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
        decimal time = decimal.Parse(Console.ReadLine());

        List<decimal> multiplied = new List<decimal>();

        MultiplyTimeByUsage(capacity, usage, time, multiplied);
        CalculateAndPrintAnswer(capacity, usage, time, multiplied);
    }

    static void MultiplyTimeByUsage(List<decimal> capacity, List<decimal> usage,
        decimal time, List<decimal> multiplied)
    {
        for (int cycle = 0; cycle < capacity.Count; cycle++)
        {
            multiplied.Add(time * usage[cycle]);
        }
    }

    static void CalculateAndPrintAnswer(List<decimal> capacity, List<decimal>
        usage, decimal time, List<decimal> multiplied)
    {
        for (int comparingCycle = 0; comparingCycle < capacity.Count; comparingCycle++)
        {
            if (capacity[comparingCycle] > multiplied[comparingCycle])
            {
                decimal percentage = (capacity[comparingCycle] - multiplied[comparingCycle])
                                       / capacity[comparingCycle]
                                      * 100M;
                Console.WriteLine("Battery {0}: {1:f2} mAh ({2:f2})%",
                    comparingCycle + 1,
                    capacity[comparingCycle] - multiplied[comparingCycle],
                    percentage);
            }
            else
            {
                decimal hours = time - 
                    Math.Truncate(
                        Math.Abs(capacity[comparingCycle] - multiplied[comparingCycle]) / usage[comparingCycle]);
                Console.WriteLine("Battery {0}: dead (lasted {1} hours)", comparingCycle + 1, hours);
            }
        }
    }
}