using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        List<int> cylinder = Console.ReadLine().Split().Select(int.Parse).ToList();

        List<string> players = Console.ReadLine().Split().ToList();

        bool deadMan = false;
        int deadPlayer = 0;

        foreach (string player in players)
        {
            string[] spinInfo = player.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(a => a.Trim()).ToArray();

            int spinStrength = int.Parse(spinInfo[0]) % cylinder.Count;
            string spinDirection = spinInfo[1];

            if (spinDirection == "Left")
            {
                cylinder = SpinLeft(cylinder, spinStrength);

            }
            else if (spinDirection == "Right")
            {
                cylinder = SpinRight(cylinder, spinStrength);
            }

            if (cylinder[2] == 1)
            {
                deadMan = true;
                deadPlayer = players.IndexOf(player);
                break;
            }
            cylinder = SpinRight(cylinder, 1); //Trigger
        }

        if (deadMan)
        {
            Console.WriteLine($"Game over! Player {deadPlayer} is dead.");
        }
        else
        {
            Console.WriteLine("Everybody got lucky!");
        }
    }

    private static List<int> SpinLeft(List<int> cylinder, int spinStrength)
    {
        for (int i = 0; i < spinStrength; i++)
        {
            cylinder = cylinder
                .Skip(1)
                .Concat(cylinder.Take(1))
                .ToList();
        }
        return cylinder;
    }

    private static List<int> SpinRight(List<int> cylinder, int spinStrength)
    {
        for (int i = 0; i < spinStrength; i++)
        {
            cylinder = cylinder
                .Skip(cylinder.Count - 1)
                .Concat(cylinder.Take(cylinder.Count - 1))
                .ToList();
        }
        return cylinder;
    }
}
