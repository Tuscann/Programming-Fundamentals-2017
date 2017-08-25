using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main() // 0/100
    {
        List<int> grapes = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        int n = int.Parse(Console.ReadLine());

        while (true)
        {
            for (int a = 0; a < n; a++)
            {
                AddingOne(grapes);
                SelectingGrapes(grapes);
            }
            RemovingBadGrapes(grapes, n);
            if (grapes.Count <= n)
            {
                break;
            }
        }
        Console.WriteLine(string.Join(" ", grapes));
    }

    private static List<int> AddingOne(List<int> values)
    {
        for (int i = 0; i < values.Count; i++)
        {
            if (values[i] > 0)
            {
                values[i]++;
            }
        }
        return values;
    }
    private static List<int> SelectingGrapes(List<int> grapes)
    {
        for (int i = 1; i < grapes.Count - 1; i++)
        {
            if (grapes[i - 1] < grapes[i] 
                && grapes[i] > grapes[i + 1])
            {
                if (grapes[i - 1] > 0)
                {
                    grapes[i] += 1;
                    grapes[i - 1] -= 2;
                }
                if (grapes[i + 1] > 0)
                {
                    grapes[i + 1] -= 2;
                }
                i++;
            }
        }
        return grapes;
    }

    private static List<int> RemovingBadGrapes(List<int> grapes, int n)
    {
        for (int i = 0; i < grapes.Count; i++)
        {
            if (grapes[i] <= n)
            {
                grapes.Remove(grapes[i]);
            }
        }
        return grapes;
    }
}