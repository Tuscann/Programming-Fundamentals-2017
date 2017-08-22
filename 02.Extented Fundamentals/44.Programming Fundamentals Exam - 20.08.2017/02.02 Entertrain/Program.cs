using System;
using System.Collections.Generic;
using System.Linq;
public class Program
{
    public static void Main() // 100/100
    {
        List<int> train = new List<int>();

        int locoPower = int.Parse(Console.ReadLine());

        string inputLine = Console.ReadLine();

        while (inputLine != "All ofboard!")
        {
            int currentWagon = int.Parse(inputLine);
            train.Add(currentWagon);

            int currentSum = train.Sum();
            if (currentSum > locoPower)
            {
                int currentAvg = currentSum / train.Count();
                int currentNearest = train[0];
                int currentDifference = Math.Abs(currentNearest - currentAvg);

                for (int i = 1; i < train.Count; i++)
                {
                    int diff = Math.Abs(train[i] - currentAvg);
                    if (diff < currentDifference)
                    {
                        currentDifference = diff;
                        currentNearest = train[i];
                    }
                }

                train.Remove(currentNearest);
            }

            inputLine = Console.ReadLine();
        }
        train.Reverse();
        train.Add(locoPower);

        Console.WriteLine(string.Join(" ", train));
    }
}