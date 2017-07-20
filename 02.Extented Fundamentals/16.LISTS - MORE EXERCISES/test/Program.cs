using System;
using System.Linq;
class Program
{
    static int[] grapes;
    static void Main()
    {
        grapes = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int n = int.Parse(Console.ReadLine());
        do
        {
            for (int cnt = 0; cnt < n; cnt++)
            {
                BloomGrapes();
            }
            KillGrapesWithPowerLesserThan(n);
        } while (StrongGrapesAreGreaterOrEqualThan(n));
        PrintLiveGrapes(n);
    }
    static bool StrongGrapesAreGreaterOrEqualThan(int threshold)
    {
        int strongGrapesCnt = 0;
        for (int cnt = 0; cnt < grapes.Length; cnt++)
        {
            if (grapes[cnt] > threshold)
            {
                strongGrapesCnt++;
            }
        }
        return strongGrapesCnt >= threshold;
    }

    static void BloomGrapes()
    {
        for (int index = 0; index < grapes.Length; index++)
        {
          
            if (!IsAlive(index) || IsLesserGrape(index))
            {
                continue;
            }
            if (IsGreaterGrape(index))
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
            }
            else
            {
                grapes[index]++;
            }
        }
    }
    static bool IsAlive(int index)
    {
        if (index < 0 || index > grapes.Length - 1 || grapes[index] <= 0)// <=
        {
            return false;
        }
        return grapes[index] > 0;
    }
    static bool IsGreaterGrape(int index)
    {
        if (index <= 0 || index >= grapes.Length - 1)
        {
            return false;
        }
        return grapes[index] > grapes[index - 1] && grapes[index] > grapes[index + 1];
    }

    static bool IsLesserGrape(int index)
    {
        return IsGreaterGrape(index - 1) || IsGreaterGrape(index + 1);
    }

    static void KillGrapesWithPowerLesserThan(int threshfold)
    {
        for (int cnt = 0; cnt < grapes.Length; cnt++)
        {
            if (grapes[cnt] <= threshfold)
            {
                grapes[cnt] = 0;
            }
        }
    }
    
    static void PrintLiveGrapes(int n)
    {
        for (int index = 0; index < grapes.Length; index++)
        {
            if (grapes[index] > n)
            {
                Console.Write(grapes[index] + " ");
            }
        }
    }
}
