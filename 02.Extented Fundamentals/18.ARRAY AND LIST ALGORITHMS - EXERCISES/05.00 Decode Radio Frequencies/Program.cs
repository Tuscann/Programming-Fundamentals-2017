using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        List<string> list = Console.ReadLine().Split().ToList();
        List<char> output = new List<char>();

        for (int i = 0; i < list.Count; i++)
        {
            string[] cerent = list[i].Split('.');

            if (cerent[0] != "0") // differnet from 0
            {
                char leftPart = (char)int.Parse(cerent[0]);
                output.Insert(i, leftPart);
            }
            if (cerent[1] != "0")
            {
                char rightPart = (char)int.Parse(cerent[1]);
                output.Insert(output.Count - i, rightPart);
            }
        }
        Console.WriteLine(string.Join("", output));
    }
}