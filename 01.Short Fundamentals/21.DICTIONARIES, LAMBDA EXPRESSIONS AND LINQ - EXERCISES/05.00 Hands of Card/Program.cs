using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        var dic = new Dictionary<string, HashSet<string>>();

        while (true)
        {
            string cur = Console.ReadLine();
            if (cur == "JOKER")
            {
                break;
            }

            List<string> curent = cur.Split(':').ToList();
            List<string> cards = curent[1].Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            string plyearName = curent[0].Trim();
            if (!dic.ContainsKey(plyearName))
            {
                dic.Add(plyearName, new HashSet<string>());
            }
            foreach (var card in cards)
            {
                dic[plyearName].Add(card);
            }
        }

        foreach (var curentList in dic)
        {
            string nameOfPerson = curentList.Key;
            int allcardSumPerPerson = 0;

            foreach (var hands in curentList.Value)
            {
                int power = 0;
                int type = 0;

                switch (hands.Remove(hands.Length - 1, 1))
                {
                    case "1": power = 1; break;
                    case "2": power = 2; break;
                    case "3": power = 3; break;
                    case "4": power = 4; break;
                    case "5": power = 5; break;
                    case "6": power = 6; break;
                    case "7": power = 7; break;
                    case "8": power = 8; break;
                    case "9": power = 9; break;
                    case "10": power = 10; break;
                    case "J": power = 11; break;
                    case "Q": power = 12; break;
                    case "K": power = 13; break;
                    case "A": power = 14; break;
                }
                char lastLetter = hands[hands.Length - 1];

                switch (lastLetter)
                {
                    case 'C': type = 1; break;
                    case 'D': type = 2; break;
                    case 'H': type = 3; break;
                    case 'S': type = 4; break;
                }
                allcardSumPerPerson += power * type;
            }
            Console.WriteLine("{0}: {1}", nameOfPerson, allcardSumPerPerson);
        }
    }
}