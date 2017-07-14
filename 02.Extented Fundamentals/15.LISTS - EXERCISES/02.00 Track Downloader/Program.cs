using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        var blackList = Console.ReadLine().Split(' ').ToList();
        var print = new List<string>();

        while (true)
        {
            string filenames = Console.ReadLine();

            bool isBlack = true;

            if (filenames == "end")
            {
                break;
            }
            for (int i = 0; i < blackList.Count; i++)
            {
                if (filenames.Contains(blackList[i]))
                {
                    isBlack = false;
                    break;
                }
            }
            if (isBlack)
            {
                print.Add(filenames);
            }
        }
        print.Sort();

        Console.WriteLine(string.Join("\n", print));
    }
}