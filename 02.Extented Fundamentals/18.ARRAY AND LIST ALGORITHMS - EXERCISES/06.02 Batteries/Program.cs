using System;
using System.Collections.Generic;
using System.Linq;
public class Batteries
{
    public static void Main() // 100/100
    {
        double[] capacity = Console.ReadLine().Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

        double[] usagePerHour = Console.ReadLine().Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

        int hours = int.Parse(Console.ReadLine());
        List<double> batteryChargePerHours = BatteryChargePerHours(capacity, usagePerHour, hours);

        List<double> chargeLeft = BatteryChargeLeft(capacity, usagePerHour, batteryChargePerHours);

        ResultOutput(capacity, hours, chargeLeft);

    }

    static List<double> BatteryChargePerHours(double[] capacity, double[] usagePerHour, int hours)
    {
        List<double> batteryChargePerHours = new List<double>();

        for (int mAh = 0; mAh < capacity.Length; mAh++)
        {
            double usage = usagePerHour[mAh] * hours;

            batteryChargePerHours.Insert(mAh, usage);
        }

        return batteryChargePerHours;
    }

    static void ResultOutput(double[] capacity, int hours, List<double> chargeLeft)
    {
        for (int i = 0; i < chargeLeft.Count; i++)
        {
            double battery = chargeLeft[i];

            if (battery > hours)
            {
                double percentage = battery * 100 / capacity[i];
                Console.WriteLine($"Battery {i + 1}: {battery:f2} mAh ({percentage:f2})%");
            }
            else
            {
                Console.WriteLine($"Battery {i + 1}: dead (lasted {battery} hours)");
            }
        }
    }

    static List<double> BatteryChargeLeft(double[] capacity, double[] usagePerHour, List<double> batteryCharge)
    {
        List<double> chargeLeft = new List<double>();

        for (int i = 0; i < capacity.Length; i++)
        {
            if (capacity[i] >= batteryCharge[i])
            {
                double resultCapacity = capacity[i] - batteryCharge[i];
                chargeLeft.Insert(i, resultCapacity);
            }
            else if (capacity[i] < batteryCharge[i])
            {
                double deadHours = Math.Ceiling(capacity[i] / usagePerHour[i]);
                chargeLeft.Insert(i, deadHours);
            }
        }

        return chargeLeft;
    }
}