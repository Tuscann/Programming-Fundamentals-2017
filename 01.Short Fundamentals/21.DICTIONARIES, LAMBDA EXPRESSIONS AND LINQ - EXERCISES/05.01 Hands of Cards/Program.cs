using System;
using System.Collections.Generic;
using System.Linq;

public class HandsOfCards
{
    public static void Main()
    {
        string input = Console.ReadLine();
        Dictionary<string, List<string>> playersCards = new Dictionary<string, List<string>>();

        while (!input.Equals("JOKER"))
        {
            string[] playerAndCards = input.Split(':');
            string name = playerAndCards[0];
            string[] cards = playerAndCards[1].Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (!playersCards.ContainsKey(name))
            {
                playersCards.Add(name, new List<string>());
            }

            playersCards[name].AddRange(cards);

            input = Console.ReadLine();
        }

        foreach (var key in playersCards)
        {
            string name = key.Key;
            var totalCards = playersCards[key.Key].Distinct().ToList();

            int sum = CalculateCardsValue(name, totalCards);

            Console.WriteLine($"{name}: {sum}");
        }
    }

    public static int CalculateCardsValue(string name, List<string> totalCards)
    {
        int sum = 0;
        foreach (var item in totalCards)
        {
            string powerAsString = "";

            if (item.Length == 3)
            {
                powerAsString = item[0].ToString() + item[1].ToString();
            }
            else
            {
                powerAsString = item[0].ToString();
            }
            string typeAsString = item[item.Length - 1].ToString();
            int power = GetPowerAsInteger(powerAsString);
            int type = GetTypeAsInteger(typeAsString);
            sum += power * type;
        }

        return sum;
    }

    public static int GetTypeAsInteger(string typeAsString)
    {
        int type = 0;

        switch (typeAsString)
        {
            case "S":
                type = 4;
                break;
            case "H":
                type = 3;
                break;
            case "D":
                type = 2;
                break;
            case "C":
                type = 1;
                break;
        }

        return type;
    }

    public static int GetPowerAsInteger(string powerAsString)
    {
        int power = 0;

        switch (powerAsString)
        {
            case "2":
                power = 2;
                break;
            case "3":
                power = 3;
                break;
            case "4":
                power = 4;
                break;
            case "5":
                power = 5;
                break;
            case "6":
                power = 6;
                break;
            case "7":
                power = 7;
                break;
            case "8":
                power = 8;
                break;
            case "9":
                power = 9;
                break;
            case "10":
                power = 10;
                break;
            case "J":
                power = 11;
                break;
            case "Q":
                power = 12;
                break;
            case "K":
                power = 13;
                break;
            case "A":
                power = 14;
                break;
        }

        return power;
    }
}