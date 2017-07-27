using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
public class Valid_Usernames
{
    public static void Main() // 100/100
    {
        string[] usernames = Console.ReadLine()
        .Split("\\ /()".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
        .Select(x => x.Trim())
        .ToArray();

        string pattern = @"^[a-zA-Z][a-zA-Z\d_]{2,24}$";

        List<string> validUsernames = new List<string>();

        foreach (string username in usernames)
        {
            Match match = Regex.Match(username, pattern);

            if (match.Success)
            {
                validUsernames.Add(username);
            }
        }

        int maxLength = 0;
        int bestIndex = 0;

        for (int i = 0; i < validUsernames.Count - 1; i++)
        {
            int currentUsernameLength = validUsernames[i].Length;
            int nextUsernameLength = validUsernames[i + 1].Length;

            if (currentUsernameLength + nextUsernameLength > maxLength)
            {
                maxLength = currentUsernameLength + nextUsernameLength;
                bestIndex = i;
            }
        }
        Console.WriteLine(validUsernames[bestIndex]);
        Console.WriteLine(validUsernames[bestIndex + 1]);
    }
}