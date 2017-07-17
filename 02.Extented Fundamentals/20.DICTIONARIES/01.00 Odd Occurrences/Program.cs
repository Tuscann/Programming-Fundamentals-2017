using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        List<string> input = Console.ReadLine().ToLower().Split().ToList();

        Dictionary<string, int> dict = new Dictionary<string, int>();

        foreach (string strings in input)
        {
            if (dict.ContainsKey(strings))
            {
                dict[strings]++;
            }
            else
            {
                dict[strings] = 1;
            }
        }
        List<string> results = new List<string>();

        foreach (KeyValuePair<string, int> strringss in dict)
        {
            if (strringss.Value % 2 != 0)  // if value is not even
            {
                results.Add(strringss.Key);
            }
        }
        Console.WriteLine(string.Join(", ", results));
    }
}
