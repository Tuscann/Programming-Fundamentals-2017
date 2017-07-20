using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        var dic = new Dictionary<string, Dictionary<string, int>>();

        while (true)
        {
            string[] curentRow = Console.ReadLine().Split(':');
            if (curentRow[0] == "ready")
            {
                break;
            }
            string country = curentRow[0];
            string[] currntTransported = curentRow[1].Split(',');

            foreach (string transport in currntTransported)
            {
                string[] x = transport.Split('-');
                string typeTransport = x[0];
                int capacity = int.Parse(x[1]);

                if (!dic.ContainsKey(country))
                {
                    dic[country] = new Dictionary<string, int>();
                }
                dic[country][typeTransport] = capacity;
            }
        }
        while (true)
        {
            string[] cureent = Console.ReadLine().Split();
            if (cureent[0] + cureent[1] == "traveltime!")
            {
                break;
            }
            string searchedCountry = cureent[0];
            int people = int.Parse(cureent[1]);

            foreach (var country in dic)
            {
                int differnce = people - country.Value.Values.Sum();

                foreach (var transport in country.Value)
                {
                    if (country.Key == searchedCountry && differnce < 0)
                    {
                        Console.WriteLine("{0} -> all {1} accommodated", searchedCountry, people);
                        break;

                    }
                    if (country.Key == searchedCountry && differnce >= 0)
                    {
                        Console.WriteLine("{0} -> all except {1} accommodated", searchedCountry, Math.Abs(differnce));
                        break;
                    }
                }
            }
        }
    }
}