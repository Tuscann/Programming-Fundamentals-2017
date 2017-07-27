using System;
using System.Text;
using System.Text.RegularExpressions;
public class Only_Letters
{
    public static void Main() // 100/100   не минава нулев тест
    {
        string message = Console.ReadLine();

        string pattern = @"(?<digit>\d+)(?<letter>\w)";
        MatchCollection matches = Regex.Matches(message, pattern);

        StringBuilder correctedMessage = new StringBuilder(message);

        foreach (Match match in matches)
        {
            string digit = match.Groups["digit"].Value;
            string letter = match.Groups["letter"].Value;

            correctedMessage.Replace(digit, letter);
        }

        Console.WriteLine(correctedMessage.ToString());
    }
}