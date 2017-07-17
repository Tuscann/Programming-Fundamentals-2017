using System;
using System.Collections.Generic;
using System.Linq;
public class SerbianUnleashed
{
    public static void Main()
    {
        string input = Console.ReadLine();
        Dictionary<string, Dictionary<string, long>> singers = new Dictionary<string, Dictionary<string, long>>();

        while (!input.Equals("End"))
        {
            string[] singerInfo = input.Split(new char[] { '@' }, StringSplitOptions.RemoveEmptyEntries);

            if (singerInfo.Length < 2)
            {
                input = Console.ReadLine();
                continue;
            }
            if (!singerInfo[0][singerInfo[0].Length - 1].Equals(' '))
            {
                input = Console.ReadLine();
                continue;
            }

            string[] singer = singerInfo[0].Split(' ');
            string singerName = string.Empty;

            for (int i = 0; i < singer.Length; i++)
            {
                singerName += singer[i];

                if (i < singer.Length - 2)
                {
                    singerName += " ";
                }
            }

            string[] venueAndPrice = singerInfo[1].Split(' ');

            if (venueAndPrice.Length < 3)
            {
                input = Console.ReadLine();
                continue;
            }

            long ticketsCount;
            long ticketsPrice;
            bool parsedticketsCount = long.TryParse(venueAndPrice[venueAndPrice.Length - 1], out ticketsCount);
            bool parsedticketsPrice = long.TryParse(venueAndPrice[venueAndPrice.Length - 2], out ticketsPrice);

            if (!parsedticketsCount || !parsedticketsPrice)
            {
                input = Console.ReadLine();
                continue;
            }

            string venue = string.Empty;

            for (int i = 0; i < venueAndPrice.Length - 2; i++)
            {
                venue += venueAndPrice[i];

                if (i < venueAndPrice.Length - 3)
                {
                    venue += " ";
                }
            }

            if (!singers.ContainsKey(venue))
            {
                singers.Add(venue, new Dictionary<string, long>());
            }
            if (!singers[venue].ContainsKey(singerName))
            {
                singers[venue].Add(singerName, 0);
            }

            singers[venue][singerName] += ticketsPrice * ticketsCount;

            input = Console.ReadLine();
        }

        foreach (var key in singers)
        {
            Console.WriteLine($"{key.Key}");

            var orderedByMoney = singers[key.Key].OrderByDescending(m => m.Value).ToList();

            foreach (var item in orderedByMoney)
            {
                Console.WriteLine($"#  {item.Key} -> {item.Value}");
            }
        }
    }
}