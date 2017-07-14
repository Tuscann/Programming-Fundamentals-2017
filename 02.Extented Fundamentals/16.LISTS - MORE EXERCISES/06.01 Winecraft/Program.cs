using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        List<int> grapeList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        int growthDays = int.Parse(Console.ReadLine());

        while (grapeList.Count > growthDays)
        {
            for (int rows = 0; rows < growthDays; rows++)
            {
                AddingOne(grapeList);
                IncreasingOne(grapeList, growthDays);
            }
            RemoveGrapes(grapeList, growthDays);
        }
        Console.WriteLine(string.Join(" ", grapeList));
    }

    private static List<int> RemoveGrapes(List<int> grapeList, int growthDays)
    {
        for (int zeroCheck = 0; zeroCheck < grapeList.Count; zeroCheck++)
        {
            if (grapeList[zeroCheck] <= growthDays)
            {
                grapeList.RemoveAt(zeroCheck);
            }
        }
        return grapeList;
    }

    private static List<int> IncreasingOne(List<int> grapeList, int growthDays)
    {
        for (int cols = 1; cols < grapeList.Count - 1; cols++)
        {
            if (grapeList[cols] > grapeList[cols - 1] && grapeList[cols] > grapeList[cols + 1])
            {
                if (grapeList[cols - 1] > 0)
                {
                    grapeList[cols]++;
                    grapeList[cols - 1] -= 2;
                }

                if (grapeList[cols + 1] > 0)
                {
                    grapeList[cols + 1] -= 2;
                }

                cols++;
            }
        }
        return grapeList;
    }

    private static List<int> AddingOne(List<int> grapeList)
    {
        for (int i = 0; i < grapeList.Count; i++)
        {
            if (grapeList[i] > 0)
            {
                grapeList[i]++;
            }
        }
        return grapeList;
    }
}
