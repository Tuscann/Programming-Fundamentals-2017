using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main() // 100/100
    {
        List<long> inputList = Console.ReadLine().Trim().Split(' ').Select(long.Parse).ToList();
        
        if (inputList.Count % 2 != 0)
        {
            try
            {
                OddCountMethod(inputList);
            }
            catch (Exception)
            {
                Console.WriteLine(string.Join(" ", inputList));
            }
        }
        else
        {
            EvenCountMethod(inputList);
        }
    }

    public static void OddCountMethod(List<long> inputList)
    {
        List<long> outputList = new List<long>();

        for (int i = 0; i < inputList.Count; i++)
        {
            outputList.Add(inputList[i]);
        }

        long last = outputList[outputList.Count - 1];
        long middle = outputList[outputList.Count / 2 + 1];
        long first = outputList[0];

        outputList.RemoveAt(outputList.Count - 1);
        outputList.RemoveAt(outputList.Count / 2 + 1);
        outputList.RemoveAt(0);

        outputList.Reverse();

        outputList.Insert(0, first);
        outputList.Insert((outputList.Count / 2), middle);
        outputList.Add(last);

        Console.WriteLine(string.Join(" ", outputList));
    }

    public static void EvenCountMethod(List<long> inputList)
    {
        List<long> outputList = new List<long>();

        for (int i = 0; i < inputList.Count; i++)
        {
            outputList.Add(inputList[i]);
        }

        long last = outputList[outputList.Count - 1];
        long first = outputList[0];

        outputList.RemoveAt(outputList.Count - 1);
        outputList.RemoveAt(0);

        outputList.Reverse();

        outputList.Insert(0, first);
        outputList.Add(last);

        Console.WriteLine(string.Join(" ", outputList));
    }
}
