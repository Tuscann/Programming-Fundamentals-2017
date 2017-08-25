using System;
using System.Text.RegularExpressions;
public class Program
{
    public static void Main() // 100/100
    {
        string pattern = @"\b([A-Z][a-z]+ [A-Z][a-z]+)\b";
        string text = Console.ReadLine();

        MatchCollection names = Regex.Matches(text, pattern);

        foreach (Match name in names)
        {
            Console.Write(name.Value + " ");
        }

        Console.WriteLine();
    }
}