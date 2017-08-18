using System;
using System.Linq;
class P05_RoundingNumbers
{
    static void Main() // 100/100
    {
        double[] inputArray = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

        double[] outputArray = (double[])inputArray.Clone();

        outputArray = inputArray.Select(element => Math.Round(element, MidpointRounding.AwayFromZero)).ToArray();

        foreach (var arrayElement in inputArray.Zip(outputArray, Tuple.Create))
        {
            Console.WriteLine($"{arrayElement.Item1} => {arrayElement.Item2}");
        }
    }
}