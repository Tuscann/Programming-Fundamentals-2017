using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
public class Program
{
    public static void Main() // 100/100
    {
        string pattern = @"([1]?[0-9AJKQ])([SHDC])";

        string inputLine = Console.ReadLine();
        Regex reg = new Regex(pattern);
        MatchCollection cards = reg.Matches(inputLine);
        List<Match> validCards = new List<Match>();

        foreach (Match card in cards)
        {
            int power = 0;
            if (int.TryParse(card.Groups[1].Value, out power))
            {
                if (power < 2 || power > 10)
                {
                    continue;
                }
            }
            validCards.Add(card);
        }
        Console.WriteLine(string.Join(", ", validCards));
    }
}