using System;
using System.Text.RegularExpressions;
public class Program
{
    public static void Main() // 100/100
    {
        string pattern = @"([>]*)<([(]+)(['\-x]{1})([>]{1})";
        Regex regex = new Regex(pattern);

        string inputLine = Console.ReadLine();

        MatchCollection fishes = regex.Matches(inputLine);

        if (fishes.Count == 0)
        {
            Console.WriteLine("No fish found.");
            return;
        }

        int count = 0;
        foreach (Match fish in fishes)
        {
            count++;
            string tailMatch = fish.Groups[1].Value;
            string bodyMatch = fish.Groups[2].Value;
            string statusMatch = fish.Groups[3].Value;

            string tailType = string.Empty;
            string bodyType = string.Empty;
            string status = string.Empty;

            if (tailMatch.Length == 0)
            {
                tailType = "  Tail type: None";
            }
            else if (tailMatch.Length == 1)
            {
                tailType = $"  Tail type: Short ({tailMatch.Length * 2} cm)";
            }
            else if (tailMatch.Length > 1 && tailMatch.Length <= 5)
            {
                tailType = $"  Tail type: Medium ({tailMatch.Length * 2} cm)";
            }
            else if (tailMatch.Length > 5)
            {
                tailType = $"  Tail type: Long ({tailMatch.Length * 2} cm)";
            }

            if (bodyMatch.Length <= 5)
            {
                bodyType = $"  Body type: Short ({bodyMatch.Length * 2} cm)";
            }
            else if (bodyMatch.Length > 5 && bodyMatch.Length <= 10)
            {
                bodyType = $"  Body type: Medium ({bodyMatch.Length * 2} cm)";
            }
            else if (bodyMatch.Length > 10)
            {
                bodyType = $"  Body type: Long ({bodyMatch.Length * 2} cm)";
            }

            switch (statusMatch)
            {
                case "'":
                    status = "Awake";
                    break;
                case "-":
                    status = "Asleep";
                    break;
                case "x":
                    status = "Dead";
                    break;
            }

            Console.WriteLine($"Fish {count}: {fish.Value}");
            Console.WriteLine(tailType);
            Console.WriteLine(bodyType);
            Console.WriteLine($"Status: {status}");
        }
    }
}