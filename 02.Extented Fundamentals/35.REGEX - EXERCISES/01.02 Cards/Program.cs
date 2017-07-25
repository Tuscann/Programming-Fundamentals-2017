using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
class Program
{
    static void Main()  // 100/100
    {
        string pattern = @"([1]?[0-9AJKQ])([SHDC])";
       
        string input = Console.ReadLine();
        Regex regex = new Regex(pattern);
        List<Match> cards = new List<Match>();
        MatchCollection validCards = regex.Matches(input);

        foreach (Match match in validCards)
        {
            int power = 0;

            if (int.TryParse(match.Groups[1].Value, out power)) //see if the card is between 2-10
            {
                if (power < 2 || power > 10) //if the power is not valid, continue
                {
                    continue;
                }
            }
            cards.Add(match); //add the matches(cards) to the list
        }
        Console.WriteLine(string.Join(", ", cards));
    }
}
