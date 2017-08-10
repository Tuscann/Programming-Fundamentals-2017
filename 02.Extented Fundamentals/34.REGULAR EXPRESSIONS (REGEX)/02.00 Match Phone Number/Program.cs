using System;
using System.Linq;
using System.Text.RegularExpressions;
class Program
{
    static void Main()
    {
        string toRegex = @"\+359( |\-)2(\1)\d{3}(\1)\d{4}\b";
        string photos = Console.ReadLine();

        MatchCollection phoneMatches = Regex.Matches(photos, toRegex);

        string[] matchedPhones = phoneMatches.Cast<Match>()
            .Select(match => match.Value.Trim()).ToArray();

        Console.WriteLine(string.Join(", ", matchedPhones));
    }
}