using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main() // 100/100
    {
        long[] beehives = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(long.Parse).ToArray();

        long[] hornets = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(long.Parse).ToArray();

        long power = hornets.Sum();
        int currentFirstHornetIndex = 0;
        for (int i = 0; i < beehives.Length; i++)
        {
            long bees = beehives[i];

            if (bees >= power)
            {
                beehives[i] -= power;
                if (currentFirstHornetIndex < hornets.Length)
                {
                    power -= hornets[currentFirstHornetIndex];
                    currentFirstHornetIndex++;
                }
            }
            else
            {
                beehives[i] -= power;
            }
        }

        if (beehives.Any(b => b > 0))
        {
            List<long> result = beehives.Where(b => b > 0).ToList();
            Console.WriteLine(string.Join(" ", result));
        }
        else
        {
            var result = hornets.Skip(currentFirstHornetIndex).ToArray();
            Console.WriteLine(string.Join(" ", result));
        }
    }
}