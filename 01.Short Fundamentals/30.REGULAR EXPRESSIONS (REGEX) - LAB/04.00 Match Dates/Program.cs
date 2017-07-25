using System;
using System.Text.RegularExpressions;
class Program
{
    static void Main()
    {
        string pattern = @"\b(?<day>[0-9]{2})(\/|-|.)(?<month>[A-Z][a-z]{2})\1(?<year>[0-9]{4})\b";
        //string pattern = @"\b(?<day>\d{2})([\/.-])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";
        
        //whenever using groups with C#, always substract one!     
        //secound group \2 become group \1
        
        string input = Console.ReadLine();

        MatchCollection datesMatches = Regex.Matches(input, pattern);

        foreach (Match date in datesMatches)
        {
            var day = date.Groups["day"].Value;
            var month = date.Groups["month"].Value;
            var year = date.Groups["year"].Value;

            Console.WriteLine("Day: {0}, Month: {1}, Year: {2}", day, month, year);
        }
    }
}