using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace HornetAssault
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<long> beehives = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            List<long> hornets = Console.ReadLine().Split(' ').Select(long.Parse).ToList();

            long summedHornetsPower = hornets.Sum();

            for (int i = 0; i < beehives.Count; i++)
            {
                if (hornets.Count == 0)
                {
                    break;
                }

                if (beehives[i] >= summedHornetsPower)
                {
                    hornets.RemoveAt(0);
                }

                beehives[i] -= summedHornetsPower;
                summedHornetsPower = hornets.Sum();
            }

            bool areSurvivors = false;
            foreach (var hive in beehives)
            {
                if (hive > 0)
                {
                    Console.Write(hive + " ");
                    areSurvivors = true;
                }
            }

            if (!areSurvivors)
            {
                Console.WriteLine(string.Join(" ", hornets));
            }

        }
    }
}