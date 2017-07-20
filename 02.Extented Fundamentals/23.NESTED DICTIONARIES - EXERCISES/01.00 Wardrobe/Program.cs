using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()    //  100/100
    {
        var dic = new Dictionary<string, Dictionary<string, int>>();

        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            var curent = Console.ReadLine().Split(new string[] { " -> " },StringSplitOptions.None).ToList();

            string color = curent[0];
            var dress = curent[1].Split(',').ToList();

            if (!dic.ContainsKey(color))
            {
                dic[color] = new Dictionary<string, int>();
            }
            foreach (var clotes in dress)
            {
                if (dic[color].ContainsKey(clotes))
                {
                    dic[color][clotes]++;
                }
                if (!dic[color].ContainsKey(clotes))
                {
                    dic[color][clotes] = 1;
                }
            }
        }
        var last = Console.ReadLine().Split(' ');

        string searchedColor = last[0];
        string searchedClothes = last[1];

        foreach (var coloorr in dic)
        {
            Console.WriteLine("{0} clothes:", coloorr.Key);
            foreach (var clothes in coloorr.Value)
            {
                Console.Write("* {0} - {1}", clothes.Key, clothes.Value);
                if (coloorr.Key == searchedColor && clothes.Key.CompareTo(searchedClothes) == 0)
                {
                    Console.Write(" (found!)");
                }
                Console.WriteLine();
            }
        }
    }
}