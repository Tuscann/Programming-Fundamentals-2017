using System;
using System.Text.RegularExpressions;

public class BoomingCannon
{
    static int[] parameters;
    static int startIndex;
    static int count;

    static bool isFirst = true;
    static string targetsShotedDown = string.Empty;

    public static void Main()
    {
        parameters = ConvertToIntegerArray(Console.ReadLine());
        startIndex = parameters[0];
        count = parameters[1];

        string target = Console.ReadLine();
        MatchAndShootOf(target);

        Console.WriteLine(targetsShotedDown);
    }

    static int[] ConvertToIntegerArray(string input)
    {
        string[] splited = input.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
        int[] integerArray = new int[splited.Length];
        for (int index = 0; index < splited.Length; index++)
        {
            integerArray[index] = Convert.ToInt32(splited[index]);
        }
        return integerArray;
    }

    static void MatchAndShootOf(string target)
    {
        string pattern = @"((?<=\\<<<)(?<target>.+?))(?=\\<<<|$)";

        if (Regex.IsMatch(target, pattern))
        {
            MatchCollection currentTargets = Regex.Matches(target, pattern);
            foreach (Match match in currentTargets)
            {
                ShootOf(match.Groups["target"].Value);
            }
        }
        else return;
    }

    static void ShootOf(string currentTarget)
    {
        string down = string.Empty;
        if (startIndex >= 0 && startIndex < currentTarget.Length)
        {
            down = SubstringFrom(currentTarget.Replace("\\<<<", string.Empty));
            AddToResult(down);
        }
        else return;
    }

    static string SubstringFrom(string currentTarget)
    {
        if (count >= 0 && startIndex + count < currentTarget.Length)
        {
            return currentTarget.Substring(startIndex, count);
        }
        else if (count >= 0 && startIndex + count >= currentTarget.Length)
        {
            return currentTarget.Substring(startIndex);
        }
        return string.Empty;
    }

    static void AddToResult(string down)
    {
        if (isFirst)
        {
            targetsShotedDown += down;
            isFirst = false;
            return;
        }
        targetsShotedDown += $"/\\{down}";
    }
}