using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
class Program
{
    static void Main()
    {
        var dict = new Dictionary<string, Dictionary<string, long>>();

        while (true)
        {
            string strings = Console.ReadLine();
            if (strings == "End")
            {
                break;
            }
            try
            {
                List<string> curentRow = strings.Split(' ').ToList();
                List<string> before = strings.Split('@').ToList();

                string singer = before[0].Trim();
                string venue = Regex.Replace(before[1], "[0-9]", "");
                int ticketsCount = int.Parse(curentRow[curentRow.Count - 1]);
                int ticketsPrice = int.Parse(curentRow[curentRow.Count - 2]);

                if (!dict.ContainsKey(venue))
                {
                    dict[venue] = new Dictionary<string, long>();
                }
                if (!dict[venue].ContainsKey(singer))
                {
                    dict[venue][singer] = 0;
                }
                dict[venue][singer] += ticketsPrice * ticketsCount;
            }
            catch (Exception e)
            {
            }
        }
        foreach (var venuess in dict)
        {
            Console.WriteLine("{0}", venuess.Key);
            foreach (var singerss in venuess.Value.OrderByDescending(y => y.Value))
            {
                Console.WriteLine("#  {0} -> {1}", singerss.Key, singerss.Value);
            }
        }
    }
}