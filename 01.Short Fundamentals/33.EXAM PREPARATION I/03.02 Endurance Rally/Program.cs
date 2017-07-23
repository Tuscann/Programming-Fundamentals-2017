using System;
using System.Linq;
class Program
{
    static void Main()
    {
        string[] names = Console.ReadLine().Split();

        decimal[] trackLayout = Console.ReadLine().Split().Select(decimal.Parse).ToArray();

        int[] indexOfTheTrack = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int rounds = names.Length;
        int letterIdentifier = 0;

        while (rounds > 0)
        {
            bool lamp = false;
            char[] toFindTheFirstLetter = names[letterIdentifier].ToCharArray();
            decimal fuelValue = toFindTheFirstLetter[0];

            for (int cycle = 0; cycle < trackLayout.Length; cycle++)
            {
                if (fuelValue > 0)
                {
                    if (indexOfTheTrack.Contains(cycle))
                    {
                        fuelValue += trackLayout[cycle];
                    }
                    else
                    {
                        fuelValue -= trackLayout[cycle];
                    }
                }
                if (fuelValue <= 0)
                {
                    Console.WriteLine($"{names[letterIdentifier]} - reached {cycle}");
                    lamp = true;
                    break;
                }
            }
            if (lamp == false)
            {
                Console.WriteLine($"{names[letterIdentifier]} - fuel left {fuelValue:f2}");
            }
            rounds--;
            letterIdentifier++;
        }
    }
}