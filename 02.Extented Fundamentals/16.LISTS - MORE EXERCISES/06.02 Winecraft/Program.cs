using System;
using System.Linq;
class Program
{
    static int[] grapes;

    static void Main()
    {
        grapes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int n = int.Parse(Console.ReadLine());
        
        do
        {
            for (int cnt = 0; cnt < n; cnt++)
            {
                BloomGrapes();
            }
            KillGrapesWithPowerLesserOrEqualToThan(n);
        }
        while (StrongGrapesAreGreaterThan(n));

        PrintLiveGrades();
    }
    static bool StrongGrapesAreGreaterThan(int threshold)
    {
        return grapes
            .Where(e => e > threshold)
            .Count() >= threshold;
    }
    static void BloomGrapes()
    {
        for (int index = 0; index < grapes.Length; index++)
        {
            if (!IsAlive(index))
            {
                continue;
            }

            if (IsGreaterGrape(index))
            {
                grapes[index]++;
                if (IsAlive(index - 1))
                {
                    grapes[index]++;
                    grapes[index - 1]--;
                }
                if (IsAlive(index + 1))
                {
                    grapes[index]++;
                    grapes[index + 1]--;
                }
            }
            else if (IsLesserGrape(index))
            {
                //do nothing
            }
            else
            {
                //Normal Grapes
                grapes[index]++;

            }
        }
    }

    static void KillGrapesWithPowerLesserOrEqualToThan(int treshold)
    {
        for (int cnt = 0; cnt < grapes.Length; cnt++)
        {
            if (grapes[cnt] <= treshold)
            {
                grapes[cnt] = 0;
            }
        }
    }

    static void PrintLiveGrades()
    {
        for (int index = 0; index < grapes.Length; index++)
        {
            if (IsAlive(index))
            {
                Console.Write(grapes[index] + " ");
            }
        }
        Console.WriteLine();
    }

    static bool IsGreaterGrape(int index)
    {
        if (index <= 0 || index >= grapes.Length - 1)
        {
            return false;
        }
        return grapes[index] > grapes[index - 1] &&
               grapes[index] > grapes[index + 1];
    }
    static bool IsLesserGrape(int index)
    {
        return IsGreaterGrape(index - 1) ||
                IsGreaterGrape(index + 1);
    }
    static bool IsAlive(int index)
    {
        if (index < 0 || index > grapes.Length)
        {
            return false;
        }
        return grapes[index] > 0;
    }
}
