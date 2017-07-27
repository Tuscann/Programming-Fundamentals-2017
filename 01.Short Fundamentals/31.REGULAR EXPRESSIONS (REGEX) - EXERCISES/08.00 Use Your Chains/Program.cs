using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
class Program
{
    static void Main()  // 100/100
    {
        string input = Console.ReadLine();

        string pattern = @"<p>(.*?)<\/p>";

        MatchCollection matches = Regex.Matches(input, pattern);

        List<string> matchesToDecrypt = new List<string>();

        foreach (Match match in matches)
        {
            string replacementPattern = @"[^a-z0-9]+";
            string replacement = " ";

            Regex regex = new Regex(replacementPattern);

            string resultWithSpaces = regex.Replace(match.Groups[1].Value.ToString(), replacement);

            matchesToDecrypt.Add(resultWithSpaces);
        }
        StringBuilder sb = new StringBuilder();
        int difference = 13;
        List<string> result = new List<string>();

        foreach (string word in matchesToDecrypt)
        {
            for (int i = 0; i < word.Length; i++)
            {
                char currentLetter = word[i];

                if (currentLetter >= 97 && currentLetter <= 109)
                {
                    currentLetter += (char)difference;
                }
                else if (currentLetter >= 110 && currentLetter <= 122)
                {
                    currentLetter -= (char)difference;
                }
                sb.Append(currentLetter);
            }

            result.Add(sb.ToString());
            sb.Clear();
        }

        Console.WriteLine(string.Join(string.Empty, result));
    }
}