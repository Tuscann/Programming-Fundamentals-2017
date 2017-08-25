using System;
using System.Linq;
using System.Text.RegularExpressions;
class Program
{
    static void Main() // 100/100
    {
        string pattern = @"\b(?:0x)?[0-9A-F]+\b";
        string input = Console.ReadLine();

        MatchCollection numbersString = Regex.Matches(input, pattern);

        string[] matchesNumbers = numbersString.Cast<Match>().Select(a => a.Value).ToArray();

        Console.WriteLine("{0}", string.Join(" ", matchesNumbers));
    }
}