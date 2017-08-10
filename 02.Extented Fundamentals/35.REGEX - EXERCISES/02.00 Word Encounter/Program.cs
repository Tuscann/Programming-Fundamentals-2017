using System;
using System.Text;
using System.Text.RegularExpressions;
public class Program
{
    public static void Main() // 100/100
    {
        StringBuilder result = new StringBuilder();

        string filter = Console.ReadLine();
        string inputLine = Console.ReadLine();

        while (inputLine != "end")
        {
            string sentencePattern = @"^[A-Z].*[.?!]$";
            Regex validSentence = new Regex(sentencePattern);

            if (validSentence.IsMatch(inputLine))
            {
                Regex regex = new Regex(@"\w+");
                MatchCollection validWords = regex.Matches(inputLine);

                char neededChar = filter[0];
                int occurences = int.Parse(filter.Substring(1));

                foreach (Match word in validWords)
                {
                    string currentWord = word.Value.ToString();
                    int count = 0;

                    for (int i = 0; i < word.Length; i++)
                    {
                        if (currentWord[i] == neededChar)
                        {
                            count++;
                        }

                        if (count == occurences)
                        {
                            result.Append($"{currentWord}, ");
                            break;
                        }
                    }
                }
            }

            inputLine = Console.ReadLine();
        }

        Console.WriteLine(result.ToString().TrimEnd(new[] { ',', ' ' }));
    }
}