using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

public class WormIpsum
{
    public static void Main() // 100/100
    {
        Regex regex = new Regex(@"[A-Z]{1}[\w\W]+?\.{1,}");
        string currentSentence = Console.ReadLine();
        while (currentSentence != "Worm Ipsum")
        {
            MatchCollection matched = regex.Matches(currentSentence);
            if (matched.Count > 1)
            {
                currentSentence = Console.ReadLine();
                continue;
            }
            string newSentence = ProcessAndValidate(currentSentence);
            Console.WriteLine($"{newSentence}.");

            currentSentence = Console.ReadLine();
        }
    }

    private static string ProcessAndValidate(string currentSentence)
    {
        string returnedSentence = string.Empty;
        string[] words = currentSentence.TrimEnd('.').Split(' ');
        bool isFirst = true;
        foreach (string word in words)
        {
            string currentWord = FindMostOccurendLetter(word);
            if (isFirst)
            {
                returnedSentence += currentWord;
                isFirst = false;
                continue;
            }
            returnedSentence += $" {currentWord}";
        }
        return returnedSentence;
    }

    static string FindMostOccurendLetter(string word)
    {
        Dictionary<char, int> symbols = new Dictionary<char, int>();
        for (int index = 0; index < word.Length; index++)
        {
            char currentSymbol = word[index];
            if (!symbols.ContainsKey(currentSymbol))
            {
                symbols[currentSymbol] = 0;
            }
            symbols[currentSymbol]++;
        }
        char returnedWord = symbols.OrderByDescending(x => x.Value).First().Key;
        int value = symbols.OrderByDescending(x => x.Value).First().Value;
        if (value >= 2)
        {
            string newWord = String.Empty;
            foreach (char t in word)
            {
                if (t == '\'')
                {
                    newWord += '\'';
                }
                else if (t == ',')
                {
                    newWord += ',';
                }
                else
                {
                    newWord += returnedWord;
                }
            }
            return newWord;
        }
        return word;
    }
}