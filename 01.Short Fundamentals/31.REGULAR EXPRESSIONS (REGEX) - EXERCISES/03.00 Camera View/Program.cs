using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main() // 83/100
    {
        List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        int m = numbers[0];
        int n = numbers[1];

        List<string> x = Console.ReadLine().Split('|').ToList();
        var dic = new Dictionary<int, List<char>>();
        int counter = 0;

        foreach (string stringg in x)
        {
            if (stringg[0].ToString() == "<"&& stringg != "")
            {
                List<char> reverse = stringg.ToArray().Skip(m + 1).Take(n).ToList();

                dic[counter] = reverse;
                counter++;
            }
        }
        for (int i = 0; i < dic.Count; i++)
        {
            if (i == dic.Count - 1)
            {
                Console.Write("{0}", string.Join("", dic[i]));
            }
            else
            {
                Console.Write("{0}, ", string.Join("", dic[i]));
            }
        }
    }
}