using System;
using System.Linq;
public class Winecraft
{
    public static void Main()
    {
        int[] grapes = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int rounds = int.Parse(Console.ReadLine());
        int grapesCounter = grapes.Length;
        int[] grapesKind = new Int32[grapesCounter];

        while (grapesCounter >= rounds) //---spin for each season until the grapes are less or equal than rounds---
        {
            for (int counter = 0; counter < rounds; counter++)  //---count the rounds---
            {
                for (int index = 0; index < grapes.Length; index++) //---calculate the grapes---
                {
                    // -1 => lesser, 0 => normal, 1 => greater 
                    for (int kindIndex = 1; kindIndex < grapes.Length - 1; kindIndex++)
                    {
                        if (grapes[kindIndex] > grapes[kindIndex - 1] && grapes[kindIndex] > grapes[kindIndex + 1])
                        {
                            grapesKind[kindIndex] = 1;
                            grapesKind[kindIndex - 1] = -1;
                            grapesKind[kindIndex + 1] = -1;
                        }
                    }
                    if (grapesKind[index] == 0 && grapes[index] > 0)
                    {
                        grapes[index]++;
                    }
                    else if (grapesKind[index] == 1)
                    {
                        grapes[index]++;
                        if (grapes[index - 1] > 0)
                        {
                            grapes[index - 1]--;
                            grapes[index]++;
                        }
                        if (grapes[index + 1] > 0)
                        {
                            grapes[index + 1]--;
                            grapes[index]++;
                        }
                        index++;
                    }
                }
            }
            grapesCounter = grapes.Length;
            for (int index = 0; index < grapes.Length; index++)
            {
                if (grapes[index] <= rounds)
                {
                    grapes[index] = 0;
                    grapesCounter--;
                }
            }
        }
        Console.WriteLine(string.Join(" ", grapes.Where(x => x > 0)));
    }
}