using System;
using System.Collections.Generic;
using System.Linq;
public class UnunionLists
{
    public static void Main()
    {
        List<int> primalList = Console.ReadLine().Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse).ToList();

        int numberOfNextLists = int.Parse(Console.ReadLine());

        string sortedPrimalList = SortPrimalList(primalList, numberOfNextLists);

        Console.WriteLine(sortedPrimalList);
    }

    static string SortPrimalList(List<int> primalList, int n)
    {
        List<int> result = primalList;

        while (n != 0)
        {
            List<int> newList = Console.ReadLine().Split(new char[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();
            int count = 0;

            for (int j = 0; j < newList.Count; j++)
            {
                int compareNumber = newList[j];

                for (int i = 0; i < result.Count; i++)
                {
                    if (result[i] == compareNumber)
                    {
                        result.RemoveAt(i);
                        i--;
                        count++;
                    }
                }
                if (count > 0)
                {
                    newList.Remove(compareNumber);
                    j--;
                    count = 0;
                }
            }

            for (int i = 0; i < newList.Count; i++)
            {
                result.Add(newList[i]);
            }
            n--;
        }
        result.Sort();

        return string.Join(" ", result);
    }
}