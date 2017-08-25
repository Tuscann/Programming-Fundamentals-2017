using System;
using System.Collections.Generic;
using System.Linq;
class InsertionSortWithList
{
    static void Main() // 100/100
    {
        List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        List<int> sortedList = new List<int>();

        DoInsertionSortWithList(list, sortedList);

        Console.WriteLine(String.Join(" ", sortedList));
    }

    static List<int> DoInsertionSortWithList(List<int> list, List<int> sortedList)
    {
        for (int firstIndex = 0; firstIndex < list.Count; firstIndex++)
        {
            int elementToInsert = list[firstIndex];
            bool hasInserted = false;

            for (int secondIndex = 0; secondIndex < sortedList.Count; secondIndex++)
            {
                int currentElement = sortedList[secondIndex];

                if (elementToInsert < currentElement)
                {
                    sortedList.Insert(secondIndex, elementToInsert);
                    hasInserted = true;
                    break;
                }
            }
            if (hasInserted == false)
            {
                sortedList.Add(elementToInsert);
            }
        }
        return sortedList;
    }
}