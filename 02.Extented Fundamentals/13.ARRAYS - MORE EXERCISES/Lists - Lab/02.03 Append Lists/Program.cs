using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        string[] InputLists = Console.ReadLine().Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

        List<int>[] output = new List<int>[InputLists.Length];

        for (int i = 0; i < InputLists.Length; i++)
        {
            output[i] = InputLists[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
        }
        for (int i = output.Count() - 1; i >= 0; i--)
        {
            for (int j = 0; j < output[i].Count(); j++)
            {
                Console.Write(output[i][j] + " ");
            }
        }
        Console.WriteLine();
    }
}