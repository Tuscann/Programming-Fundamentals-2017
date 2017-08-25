using System;
using System.Linq;
using System.Text.RegularExpressions;
class Program
{
    static void Main() // 100/100
    {
        // string pattern = @"\+359( |\-)2(\1)\d{3}(\1)\d{4}\b";
        string pattern = @"(\+359([ |-])2\2\d{3}\2\d{4})\b";
        string photos = Console.ReadLine();

        MatchCollection phoneMatches = Regex.Matches(photos, pattern);

        string[] matchedPhones = phoneMatches.Cast<Match>()
            .Select(match => match.Value.Trim()).ToArray();

        Console.WriteLine(string.Join(", ", matchedPhones));
    }
}