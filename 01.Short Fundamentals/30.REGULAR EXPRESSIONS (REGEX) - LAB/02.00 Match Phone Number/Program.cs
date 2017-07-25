using System;
using System.Linq;
using System.Text.RegularExpressions;
class Program
{
    static void Main() // 100/100
    {
        string pattern = @"\+359( |\-)2(\1)[0-9]{3}(\1)[0-9]{4}\b";
        // string toRegex = @"\+359( |\-)2(\1)\d{3}(\1)\d{4}\b";
        
        string phones = Console.ReadLine();

        MatchCollection phoneMatches = Regex.Matches(phones, pattern);

        string[] matchesPhones = phoneMatches.Cast<Match>().Select(a => a.Value.Trim()).ToArray();
        
        Console.WriteLine("{0}", string.Join(", ", matchesPhones));
    }
}