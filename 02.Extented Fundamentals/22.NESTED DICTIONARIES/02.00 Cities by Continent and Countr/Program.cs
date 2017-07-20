using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        var dic = new Dictionary<string, Dictionary<string, List<string>>>();

        for (int i = 0; i < n; i++)
        {
            var current = Console.ReadLine().Split().ToList();

            string continents = current[0];
            string countries = current[1];
            string cities = current[2];
            
            if (dic.ContainsKey(continents))
            {
                if (!dic[continents].ContainsKey(countries))
                {
                    dic[continents].Add(countries, new List<string>());
                }
            }
            if (!dic.ContainsKey(continents))
            {
                dic[continents] = new Dictionary<string, List<string>>();
                dic[continents].Add(countries, new List<string>());               
            }
            dic[continents][countries].Add(cities);
        }
        foreach (var continent in dic)
        {
            Console.WriteLine("{0}:", continent.Key);
            foreach (var countries in continent.Value)
            {
                Console.WriteLine("  {0} -> {1}",  countries.Key,string.Join(", ",countries.Value));
            }
        }
    }
}