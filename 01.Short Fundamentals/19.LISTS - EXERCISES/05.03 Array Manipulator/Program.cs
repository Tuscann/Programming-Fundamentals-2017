using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        List<long> list = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
        
        while (true)
        {
            string[] tokens = Console.ReadLine().Split(' ');
            if (tokens[0] == "print")
            {
                break;
            }
            switch (tokens[0])
            {
                case "add":
                    int index = int.Parse(tokens[1]);
                    long element = long.Parse(tokens[2]);
                    list.Insert(index, element);
                    break;
                case "addMany":
                    int index2 = int.Parse(tokens[1]);
                    List<long> elementsToAdd = tokens.Skip(2).Select(long.Parse).ToList();
                    list.InsertRange(index2, elementsToAdd);
                    break;
                case "contains":
                    long element2 = long.Parse(tokens[1]);
                    Console.WriteLine(list.IndexOf(element2));
                    break;
                case "remove":
                    int index3 = int.Parse(tokens[1]);
                    list.RemoveAt(index3);
                    break;
                case "shift":
                    int positions = int.Parse(tokens[1]);
                    for (int i = 0; i < positions; i++)
                    {
                        long lastElement = list[0];
                        for (int j = 0; j < list.Count - 1; j++)
                        {
                            list[j] = list[j + 1];
                        }
                        list[list.Count - 1] = lastElement;
                    }
                    break;
                case "sumPairs":
                    List<long> newList = new List<long>();
                    for (int i = 0; i < list.Count - 1; i += 2)
                    {
                        newList.Add(list[i] + list[i + 1]);
                    }
                    if (list.Count % 2 == 1)
                    {
                        newList.Add(list[list.Count - 1]);
                    }
                    list = newList;
                    break;
            }
        }
        Console.WriteLine("[" + string.Join(", ", list) + "]");
    }
}