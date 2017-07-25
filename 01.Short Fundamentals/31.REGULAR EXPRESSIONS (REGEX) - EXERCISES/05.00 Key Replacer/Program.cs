using System;
using System.Linq;
using System.Text.RegularExpressions;
class Program
{
    static void Main()  // 83/100
    {
        string pattern = @"([a-z]{1,})([\||<|\\])";
        string input = Console.ReadLine();

        MatchCollection matches = Regex.Matches(input, pattern);

        string first = String.Empty;
        string last = String.Empty;

        foreach (Match match in matches)
        {
            first = match.Groups[1].Value.ToString();
            break;
        }
        input = new string(input.Reverse().ToArray());

        MatchCollection matchess = Regex.Matches(input, pattern);

        foreach (Match match in matchess)
        {
            last = match.Groups[1].Value.ToString();
            break;
        }
        last = new string(last.Reverse().ToArray());

        string secoundRow = Console.ReadLine();
        string textPattern = $@"{first}(?<word>.*?){last}";
        MatchCollection matches2 = Regex.Matches(secoundRow, textPattern);

        if (matches2.Count == 0)
        {
            Console.WriteLine("Empty result");
        }
        else
        {
            foreach (Match match in matches2)
            {
                Console.Write(match.Groups["word"].Value.ToString());
            }
        }
    }
}