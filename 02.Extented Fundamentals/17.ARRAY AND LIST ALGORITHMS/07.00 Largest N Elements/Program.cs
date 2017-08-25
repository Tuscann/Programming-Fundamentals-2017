using System;
using System.Collections.Generic;
using System.Linq;
class LargestNElements_2
{
    static void Main() // 100/100
    {
        List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        int n = int.Parse(Console.ReadLine());
        List<int> resultList = new List<int>();

        DoInsertionSort(list);
        GetLargestNElements(list, n, resultList);
        Console.WriteLine(String.Join(" ", resultList));
    }

    static List<int> DoInsertionSort(List<int> list)
    {
        for (int firstIndex = 1; firstIndex < list.Count; firstIndex++)
        {
            for (int secondIndex = firstIndex; secondIndex > 0; secondIndex--)
            {
                int currentElement = list[secondIndex];
                int previousElement = list[secondIndex - 1];
                if (previousElement < currentElement)
                {
                    list[secondIndex] = Swap(currentElement, previousElement).Item1;
                    list[secondIndex - 1] = Swap(currentElement, previousElement).Item2;
                }
                else
                {
                    break;
                }
            }
        }
        return list;
    }

    static Tuple<int, int> Swap(int first, int second)
    {
        int temp = first;
        first = second;
        second = temp;
        return new Tuple<int, int>(first, second);
    }

    static List<int> GetLargestNElements(List<int> list, int n, List<int> resultList)
    {
        for (int i = 0; i < n; i++)
        {
            int currentElements = list[i];
            resultList.Add(currentElements);
        }
        return resultList;
    }
}