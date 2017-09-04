using System;
using System.Text;
using System.Text.RegularExpressions;

public class Regexmon
{
    public static void Main()
    {
        string input = Console.ReadLine();
        string bojoPattern = @"[a-zA-Z]+-[a-zA-Z]+";
        string didiPattern = @"[^a-zA-Z-]+";
        StringBuilder sb = new StringBuilder();
        sb.Append(input);
        Regex regexBojo = new Regex(bojoPattern);
        Regex regexDidi = new Regex(didiPattern);
        int count = 1;

        while (sb.Length > 0)
        {
            bool isFound = false;
            if (count % 2 != 0)
            {
                isFound = regexDidi.IsMatch(sb.ToString());
            }
            else
            {
                isFound = regexBojo.IsMatch(sb.ToString());
            }

            if (isFound)
            {
                if (count % 2 != 0)
                {
                    Match match = regexDidi.Match(sb.ToString());
                    Console.WriteLine(match.Groups[0]);
                    int index = sb.ToString().IndexOf(match.Groups[0].ToString(), 0);
                    sb.Remove(0, match.Groups[0].ToString().Length + index);
                }
                else
                {
                    Match match = regexBojo.Match(sb.ToString());
                    Console.WriteLine(match.Groups[0]);
                    int index = sb.ToString().IndexOf(match.Groups[0].ToString(), 0);
                    sb.Remove(0, match.Groups[0].ToString().Length + index);
                }
            }
            else
            {
                return;
            }

            count++;
        }
    }
}