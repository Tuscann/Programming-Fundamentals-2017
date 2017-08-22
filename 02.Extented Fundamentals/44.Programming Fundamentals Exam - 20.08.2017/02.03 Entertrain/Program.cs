using System;
using System.Collections.Generic;

public class Entertrain
{
    static long locomotivsPower;
    static long compositionSum;
    static List<long> composition = new List<long>();

    public static void Main() // 60/100
    {
        locomotivsPower = Convert.ToInt64(Console.ReadLine());
        ReadNextLinesFrom(Console.ReadLine());
        composition.Reverse();
        composition.Add(locomotivsPower);
        Console.WriteLine(string.Join(" ", composition));
    }

    public static void ReadNextLinesFrom(string input)
    {
        if (input != "All ofboard!")
        {
            long currentVagoon = Convert.ToInt64(input);
            compositionSum += currentVagoon;
            composition.Add(currentVagoon);

            if (compositionSum > locomotivsPower)
            {
                long average = compositionSum / composition.Count;
                long closestElement = FindClosestElementTo(average);
                composition.Remove(closestElement);
            }

            ReadNextLinesFrom(Console.ReadLine());
        }
    }

    public static long FindClosestElementTo(long average)
    {
        long diference = long.MaxValue;
        long closestElement = 0L;

        for (int i = 0; i < composition.Count; i++)
        {
            long temporaryDifernce = Math.Abs(composition[i] - average);
            if (temporaryDifernce < diference)
            {
                closestElement = composition[i];
                diference = temporaryDifernce;
            }
        }
        return closestElement;
    }
}