using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Email_Statistics  // 100/100
{
    public static void Main()
    {
        Dictionary<string, HashSet<string>> emails = new Dictionary<string, HashSet<string>>();

        int emailsCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < emailsCount; i++)
        {
            string email = Console.ReadLine();

            string emailPattern = @"^(?<username>[a-zA-Z]{5,})@(?<domain>(?<mailServer>[a-z]{3,})(?<topDomain>\.com|\.bg|\.org))$";
            Match match = Regex.Match(email, emailPattern);

            if (match.Success)
            {
                string domain = match.Groups["domain"].Value;
                string username = match.Groups["username"].Value;

                if (!emails.ContainsKey(domain))
                {
                    emails[domain] = new HashSet<string>();
                }

                if (!emails[domain].Contains(username))
                {
                    emails[domain].Add(username);
                }
            }
        }

        foreach (KeyValuePair<string, HashSet<string>> email in emails.OrderByDescending(x => x.Value.Count))
        {
            string domain = email.Key;
            HashSet<string> usernames = email.Value;

            Console.WriteLine($"{domain}:");

            foreach (string username in usernames)
            {
                Console.WriteLine($"### {username}");
            }
        }
    }
}