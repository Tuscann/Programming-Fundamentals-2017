using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main() // 80/100
    {
        int n = int.Parse(Console.ReadLine());
        List<int> result = new List<int>();

        for (int i = 0; i < n; i++)
        {
            List<int> newList = new List<int>();
            newList = GetANewList(newList);
            bool areAllIncreasing = CheckIfAllAreIncreasing(newList);
            AddIncreasingElements(newList, i, result, areAllIncreasing);

        }
        Console.WriteLine(String.Join(" ", result));
    }

    static List<int> GetANewList(List<int> newList)
    {
        newList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        return newList;
    }

    static bool CheckIfAllAreIncreasing(List<int> newList)
    {
        for (int i = 0; i < newList.Count - 1; i++)
        {
            if (newList[i] > newList[i + 1])
            {
                return false;
            }
        }
        return true;
    }

    static List<int> AddIncreasingElements(List<int> newList, int i, List<int> result,
        bool areAllIncreasing)
    {
        if (i == 0)
        {
            for (int index = 0; index < newList.Count; index++)
            {
                result.Add(newList[index]);
            }
            return result;
        }
        if (areAllIncreasing)
        {
            InsertElementOfIncreasingSequence(result, newList);
        }
        else
        {
            InsertElementOfNonIncreasingSequence(result, newList);
        }
        return newList;
    }

    static List<int> InsertElementOfIncreasingSequence(List<int> result, List<int> newList)
    {
        bool hasInserted = false;
        for (int index = 0; index < result.Count; index++)
        {
            int currentListElement = result[index];
            if (newList[0] < currentListElement)
            {
                for (int i = 0; i < newList.Count; i++)
                {
                    result.Insert(index, newList[i]);
                    index++;
                    hasInserted = true;
                }

            }
        }

        if (hasInserted == false)
        {
            for (int i = 0; i < newList.Count; i++)
            {
                result.Add(newList[i]);
            }
        }

        for (int index = 1; index < result.Count; index++)
        {
            if (result[index - 1] > result[index])
            {
                int count = result.Count - index;
                result.RemoveRange(index, count);
                /*result.RemoveAt(index);
                index--;*/
                break;
            }
        }
        //Console.WriteLine(String.Join(" ", result));
        return result;
    }

    static List<int> InsertElementOfNonIncreasingSequence(List<int> result, List<int> newList)
    {
        int lastInserted = 0;

        for (int index = 0; index < result.Count; index++)
        {
            int currentListElement = result[index];

            //result.Insert(index, newList[0]);
            if (newList[0] <= currentListElement)
            {
                result.Insert(index, newList[0]);
                //for (int i = 0; i < newList.Count; i++)
                //{
                int i = 1;
                while (newList[i - 1] <= newList[i])
                {
                    result.Insert(index, newList[i - 1]);
                    index++;
                    i++;
                }
                i--;
                lastInserted = newList[i];
                break;
            }
            else
            {
                result.Add(newList[0]);
                //for (int i = 0; i < newList.Count; i++)
                //{
                int i = 1;
                while (newList[i - 1] <= newList[i])
                {
                    result.Add(newList[i]);
                    index++;
                    i++;
                }
                i--;
                lastInserted = newList[i];
                break;
            }
        }
        // Console.WriteLine(String.Join(" ", result));
        RemoveElements(result, lastInserted);
        // Console.WriteLine("LAST INSERTED: " + lastInserted);
        //Console.WriteLine(String.Join(" ", result));
        return result;
    }

    static List<int> RemoveElements(List<int> result, int lastInserted)
    {
        for (int index = 0; index < result.Count; index++)
        {
            int currentListElement = result[index];
            if (lastInserted < currentListElement)
            {
                result.Remove(currentListElement);
                index--;
            }
        }
        //    Console.WriteLine(String.Join(" ", result));
        return result;
    }
}