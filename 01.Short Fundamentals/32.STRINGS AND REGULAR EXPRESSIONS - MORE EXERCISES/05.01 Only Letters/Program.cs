using System;
using System.Text.RegularExpressions;
class Program
{
    static void Main() // 100/100
    {
        string inputLine = Console.ReadLine();

        Regex toRegex = new Regex(@"(\d+)([A-Za-z])");

        MatchCollection replacer = toRegex.Matches(inputLine);

        foreach (Match find in replacer)
        {
            inputLine = Regex.Replace(inputLine, find.Groups[1].Value.ToString(), find.Groups[2].Value.ToString());
        }
        Console.WriteLine(inputLine);
    }
}
