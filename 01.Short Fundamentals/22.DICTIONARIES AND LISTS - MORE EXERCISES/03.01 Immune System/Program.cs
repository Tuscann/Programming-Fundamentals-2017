using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        int initialHealth = int.Parse(Console.ReadLine());
        string virusName = Console.ReadLine();

        List<string> virusesFought = new List<string>();

        int workingHealth = initialHealth;
        bool lamp = false;

        while (virusName != "end")
        {
            char[] splitVirusWithLessTimeToKill = virusName.ToCharArray();
            decimal totalVirusStrenghtLess = 0;

            for (int cycle = 0; cycle < splitVirusWithLessTimeToKill.Length; cycle++)
            {
                totalVirusStrenghtLess += splitVirusWithLessTimeToKill[cycle];
            }
            int timeToDefeatTheVirusLess = (int)Math.Truncate(totalVirusStrenghtLess / 3);

            int totalTimeInSeconds = 0;
            if (virusesFought.Contains(virusName))
            {
                totalTimeInSeconds = timeToDefeatTheVirusLess * splitVirusWithLessTimeToKill.Length / 3;
            }
            else
            {
                totalTimeInSeconds = timeToDefeatTheVirusLess * splitVirusWithLessTimeToKill.Length;
            }

            int timeMinutesLess = totalTimeInSeconds / 60;
            int timeSecondsLess = totalTimeInSeconds % 60;

            workingHealth -= totalTimeInSeconds;
            
            Console.WriteLine($"Virus {virusName}: {timeToDefeatTheVirusLess} => {totalTimeInSeconds} seconds");
            if (workingHealth < 0)
            {
                lamp = false;
                break;
            }
            Console.WriteLine($"{virusName} defeated in {timeMinutesLess}m {timeSecondsLess}s.");
            Console.WriteLine("Remaining health: {0}", workingHealth);

            workingHealth = (int)Math.Truncate(workingHealth * 1.2);

            if (workingHealth > initialHealth)
            {
                workingHealth = initialHealth;
            }
            lamp = true;
            virusesFought.Add(virusName);

            virusName = Console.ReadLine();
        }

        if (lamp == true)
        {
            Console.WriteLine("Final Health: {0}", workingHealth);
        }
        else
        {
            Console.WriteLine("Immune System Defeated.");
        }
    }
}
