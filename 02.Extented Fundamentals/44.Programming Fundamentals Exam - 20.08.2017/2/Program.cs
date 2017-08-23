using System;
using System.Collections.Generic;
using System.Linq;
public class Entertrain
{
    public static void Main() // 100/100
    {
        int locPower = int.Parse(Console.ReadLine());

        string input = Console.ReadLine();

        List<int> wagons = new List<int>();

        while (input != "All ofboard!")
        {
            int wagonWeight = int.Parse(input);

            int averageWeeight = 0;

            wagons.Add(wagonWeight);

            int wagonsSum = wagons.Sum();

            if (wagonsSum > locPower)
            {
                averageWeeight = (int)wagons.Average();

                int closest = wagons.OrderBy(item => Math.Abs(averageWeeight - item)).First();
                int closestIndex = wagons.IndexOf(closest);
                wagons.RemoveAt(closestIndex);
            }

            input = Console.ReadLine();
        }

        wagons.Reverse();
        wagons.Add(locPower);

        Console.WriteLine(string.Join(" ", wagons));
    }
}