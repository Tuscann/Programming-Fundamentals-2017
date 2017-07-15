using System;
using System.Collections.Generic;
using System.Linq;
class HandsOfCards
{
    static void Main()
    {
        Dictionary<string, int> scores = new Dictionary<string, int>();
        Dictionary<string, string> playersAndCards = new Dictionary<string, string>();

        while (true)
        {
            string[] input = Console.ReadLine().Split(':');
            string playerName = input[0];

            if (playerName == "JOKER")
            {
                break;
            }

            if (playersAndCards.ContainsKey(playerName))
            {
                playersAndCards[playerName] += input[1];
            }
            else
            {
                playersAndCards.Add(playerName, input[1]);
            }
        }

        foreach (KeyValuePair<string, string> pCards in playersAndCards)
        {
            List<string> playerCards = new List<string>();

            playerCards = pCards.Value.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Distinct().ToList();

            int sumOfHand = 0;
            foreach (string card in playerCards)
            {
                sumOfHand += CardPoints(card);
            }

            if (scores.ContainsKey(pCards.Key))
            {
                scores[pCards.Key] += sumOfHand;
            }
            else
            {
                scores.Add(pCards.Key, sumOfHand);
            }
        }

        foreach (KeyValuePair<string, int> score in scores)
        {
            Console.WriteLine($"{score.Key}: {score.Value}");
        }
    }

    private static int CardPoints(string card)
    {
        string power = card[0].ToString();
        string type = card[card.Length - 1].ToString();
        if (power == "1")
        {
            power = "10";
        }
        int powerAsNumber = 0;
        int typeAsNumber = 0;
        bool nPower = int.TryParse(power, out powerAsNumber);  //For the numerical values

        if (nPower == false)
        {
            switch (power)//J, Q, K, A
            {
                case "J":
                    powerAsNumber = 11;
                    break;
                case "Q":
                    powerAsNumber = 12;
                    break;
                case "K":
                    powerAsNumber = 13;
                    break;
                case "A":
                    powerAsNumber = 14;
                    break;
            }
        }
        switch (type)//S -> 4, H-> 3, D -> 2, C -> 1
        {
            case "S":
                typeAsNumber = 4;
                break;
            case "H":
                typeAsNumber = 3;
                break;
            case "D":
                typeAsNumber = 2;
                break;
            case "C":
                typeAsNumber = 1;
                break;
        }
        int cardPoints = powerAsNumber * typeAsNumber;
        return cardPoints;
    }
}
