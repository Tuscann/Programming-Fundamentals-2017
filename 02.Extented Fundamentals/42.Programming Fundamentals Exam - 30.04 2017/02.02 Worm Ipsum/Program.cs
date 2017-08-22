using System;
using System.Linq;
using System.Text.RegularExpressions;
public class WormIpsum
{
    public static void Main() // 100/100
    {
        Regex sentenceReg = new Regex(@"^[A-Z][^\.]*\.$");
        Regex wordsReg = new Regex(@"[^\s,\.]+");

        string inputLine = Console.ReadLine();
        while (!inputLine.Equals("Worm Ipsum"))
        {
            Match sentenceMatch = sentenceReg.Match(inputLine);
            if (sentenceMatch.Success)
            {
                MatchCollection wordsMatches = wordsReg.Matches(inputLine);
                foreach (Match match in wordsMatches)
                {
                    string currentWord = match.Value;
                    if (currentWord.Length != currentWord.Distinct().Count())
                    {
                        char symbol = currentWord.GroupBy(x => x).OrderByDescending(x => x.Count()).First().Key;
                        string newWord = string.Concat(Enumerable.Repeat(symbol, currentWord.Length));
                        inputLine = Regex.Replace(inputLine, currentWord, newWord);
                    }
                }
                Console.WriteLine(inputLine);
            }
            inputLine = Console.ReadLine();
        }
    }
}