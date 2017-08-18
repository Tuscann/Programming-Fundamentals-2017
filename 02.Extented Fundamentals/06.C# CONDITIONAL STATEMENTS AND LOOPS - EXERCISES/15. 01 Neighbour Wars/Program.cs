using System;

class P15_NeighbourWars
{
    static void Main() // 100/100
    {
        int peshosRoundhouseKickDamage = int.Parse(Console.ReadLine());
        int goshosThunderousFistDamage = int.Parse(Console.ReadLine());

        int peshosHealth = 100;
        int goshosHealth = 100;
        bool isPeshoAlive = true;
        bool isGoshoAlive = true;

        int roundsCount = 0;

        while (isPeshoAlive && isGoshoAlive)
        {
            roundsCount++;

            if (roundsCount % 2 == 1)
            {// Pesho attacs
                goshosHealth -= peshosRoundhouseKickDamage;
                if (goshosHealth <= 0)
                {
                    isGoshoAlive = false;
                    continue;
                }
                Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshosHealth} health.");
            }
            else
            {
                peshosHealth -= goshosThunderousFistDamage;
                if (peshosHealth <= 0)
                {
                    isPeshoAlive = false;
                    continue;
                }
                Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshosHealth} health.");
            }

            if (roundsCount % 3 == 0)
            {
                peshosHealth += 10;
                goshosHealth += 10;
            }
        }

        if (isPeshoAlive)
        {
            Console.WriteLine($"Pesho won in {roundsCount}th round.");
        }
        else
        {
            Console.WriteLine($"Gosho won in {roundsCount}th round.");
        }
    }
}
