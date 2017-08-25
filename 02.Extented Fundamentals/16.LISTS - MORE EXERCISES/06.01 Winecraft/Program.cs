using System;
using System.Collections.Generic;
using System.Linq;
class Winecraft
{
    static void Main()   // 88/100
    {
        List<int> grapes = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
        List<int> positionsGreats = new List<int>();
        List<int> positionsLesser = new List<int>();

        int daysGrowing = int.Parse(Console.ReadLine());
        do
        {
            for (int br2 = 0; br2 < daysGrowing; br2++)
            {
                positionsLesser = CleanUpLesser(grapes, positionsLesser);
                positionsGreats = IfGreater(grapes, positionsGreats);
                positionsLesser = IfLesser(grapes, positionsLesser, positionsGreats);
                positionsLesser = CleanUpLesser(grapes, positionsLesser);
                grapes = GrowOrdinary(grapes, positionsLesser, positionsGreats);
                grapes = GrowGreats(grapes, positionsLesser, positionsGreats);
                positionsLesser = CleanUpLesser(grapes, positionsLesser);
            }
            grapes = SetToZero(grapes, daysGrowing);
        }
        while (RepeatValid(grapes, daysGrowing));

        grapes.RemoveAll(a => a == 0);

        Console.WriteLine(string.Join(" ", grapes));
    }
    static List<int> SetToZero(List<int> grapes, int daysGrowing)
    {
        for (int br = 0; br < grapes.Count; br++)
        {
            if (grapes[br] <= daysGrowing)
            {
                grapes[br] = 0;
            }
        }
        return grapes;
    }
    static List<int> GrowGreats(List<int> grapes, List<int> positionsLesser, List<int> positionsGreats)
    {
        for (int br = 0; br < grapes.Count; br++)
        {
            if (positionsGreats.Contains(br))
            {
                if (positionsLesser.Contains(br - 1) && grapes[br - 1] != 0)
                {
                    grapes[br]++;
                    grapes[br - 1]--;
                }

                if (positionsLesser.Contains(br + 1) && grapes[br + 1] != 0)
                {
                    grapes[br]++;
                    grapes[br + 1]--;
                }
            }
        }
        return grapes;
    }
    static List<int> GrowOrdinary(List<int> grapes, List<int> positionsLesser, List<int> positionsGreats)
    {
        for (int br = 0; br < grapes.Count; br++)
        {
            if (!positionsLesser.Contains(br) && grapes[br] != 0)
            {
                grapes[br]++;
            }
        }
        return grapes;
    }
    static List<int> IfGreater(List<int> grapes, List<int> positionsGreats)
    {
        for (int br = 0; br < grapes.Count; br++)
        {
            if (br > 0 && br < grapes.Count - 1)
            {
                if (grapes[br - 1] < grapes[br] && grapes[br + 1] < grapes[br])
                    if (!positionsGreats.Contains(br))
                        positionsGreats.Add(br);
            }
        }
        return positionsGreats;
    }
    static List<int> DecreaseLesser(List<int> grapes, List<int> positionsLesser, List<int> positionsGreats)
    {
        for (int br = 0; br < grapes.Count; br++)
        {
            if (positionsLesser.Contains(br))
            {
                grapes[br]--;
            }
        }
        return grapes;
    }
    static List<int> IfLesser(List<int> grapes, List<int> positionsLesser, List<int> positionsGreats)
    {
        for (int br = 0; br < grapes.Count; br++)
        {
            if (positionsGreats.Contains(br + 1) || positionsGreats.Contains(br - 1))
                if (!(positionsLesser.Contains(br)) && grapes[br] != 0)
                    positionsLesser.Add(br);
        }
        return positionsLesser;
    }
    static List<int> CleanUpLesser(List<int> grapes, List<int> postionsLesser)
    {
        postionsLesser.RemoveAll(a => grapes[a] == 0);
        return postionsLesser;
    }
    static bool RepeatValid(List<int> grapes, int N)
    {
        int nonzero = 0;
        for (int br = 0; br < grapes.Count; br++)
        {
            if (grapes[br] != 0)
            {
                nonzero++;
            }
        }
        if (nonzero < N)
        {
            /*for(int br = 0; br < grapes.Count; br++)
            {
                if (grapes[br] <= N&&grapes[br]!=0)
                    return true;
            }*/
        }
        else
        {
            return true;
        }
        return false;
    }
}