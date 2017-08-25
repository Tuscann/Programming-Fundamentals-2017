using System;
using System.Text.RegularExpressions;
public class Program
{
    public static void Main() // 100/100
    {
        string happyPattern = @"(:\)|:D|;\)|:\*|:]|;]|:}|;}|\(:|\*:|c:|\[:|\[;)";
        string sadPattern = @"(:\(|D:|;\(|:\[|;\[|:{|;{|\):|:c|\]:|\];)";

        double happinessIndex = 0.0;

        string input = Console.ReadLine();

        MatchCollection happyEmoticons = Regex.Matches(input, happyPattern);
        MatchCollection sadEmoticons = Regex.Matches(input, sadPattern);

        happinessIndex = (double)happyEmoticons.Count / sadEmoticons.Count;

        string status = string.Empty;

        if (happinessIndex >= 2)
        {
            status = ":D";
        }
        else if (happinessIndex > 1)
        {
            status = ":)";
        }
        else if (happinessIndex == 1)
        {
            status = ":|";
        }
        else if (happinessIndex < 1)
        {
            status = ":(";
        }

        Console.WriteLine($"Happiness index: {happinessIndex:F2} {status}");
        Console.WriteLine($"[Happy count: {happyEmoticons.Count}, Sad count: {sadEmoticons.Count}]");
    }
}