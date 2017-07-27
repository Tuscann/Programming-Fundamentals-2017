using System;
using System.Text.RegularExpressions;
public class Extract_Sentences_by_Keyword
{
    public static void Main()   // 100/100
    {
        string word = Console.ReadLine();

        string[] text = Console.ReadLine()
            .Split(".!?".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

        string pattern = $@"(\b{word}\b)";

        foreach (string sentence in text)
        {
            Match match = Regex.Match(sentence, pattern);

            if (match.Success)
            {
                Console.WriteLine(sentence.Trim());
            }
        }
    }
}