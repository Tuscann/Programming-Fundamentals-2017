using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main() // 100/100
    {
        List<int> insertionList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        string newDigit = Console.ReadLine();

        ConvertAndInputInTheList(insertionList, newDigit);

        Console.WriteLine(string.Join(" ", insertionList));
    }
    static List<int> ConvertAndInputInTheList(List<int> insertionList, string newDigit)
    {
        while (newDigit != "end")
        {
            int parsedInt = int.Parse(newDigit);
            int toBeInserted = parsedInt;
            while (parsedInt > 10)
            {
                parsedInt /= 10;
            }
            insertionList.Insert(parsedInt, toBeInserted);
            newDigit = Console.ReadLine();
        }
        return insertionList;
    }
}