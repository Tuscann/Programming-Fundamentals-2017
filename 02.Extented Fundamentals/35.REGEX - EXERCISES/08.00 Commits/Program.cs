using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Commit
{
    public string Hash { get; set; }

    public string Message { get; set; }

    public decimal Additions { get; set; }

    public decimal Deletions { get; set; }

    public Commit(string hash, string message, decimal additions, decimal deletions)
    {
        Hash = hash;
        this.Message = message;
        this.Additions = additions;
        this.Deletions = deletions;
    }

}
public class Program
{
    public static void Main() // 100/100
    {
        var users = new SortedDictionary<string, SortedDictionary<string, List<Commit>>>();

        string pattern = @"^https:\/\/github.com\/([A-Za-z0-9\-]+)\/([A-Za-z\-_]+)\/commit\/([0-9a-f]{40}),([^\n]*),([0-9]*),([0-9]*)$";
        Regex regex = new Regex(pattern);

        string inputLine = Console.ReadLine();

        while (inputLine != "git push")
        {
            var userAndCommit = regex.Match(inputLine);

            if (userAndCommit.Success)
            {
                string userName = userAndCommit.Groups[1].Value;
                string repoName = userAndCommit.Groups[2].Value;

                string hash = userAndCommit.Groups[3].Value;
                string message = userAndCommit.Groups[4].Value;

                decimal additions = decimal.Parse(userAndCommit.Groups[5].Value);
                decimal deletions = decimal.Parse(userAndCommit.Groups[6].Value);

                var currentCommit = new Commit(hash, message, additions, deletions);

                if (!users.ContainsKey(userName))
                {
                    users[userName] = new SortedDictionary<string, List<Commit>>();
                }
                if (!users[userName].ContainsKey(repoName))
                {
                    users[userName][repoName] = new List<Commit>();
                }

                users[userName][repoName].Add(currentCommit);
            }

            inputLine = Console.ReadLine();
        }

        decimal additionsSum = 0m;
        decimal deletionsSum = 0m;

        foreach (var user in users)
        {
            Console.WriteLine($"{user.Key}:");

            foreach (var repo in users[user.Key])
            {
                Console.WriteLine($"{repo.Key}:");

                foreach (var commit in repo.Value)
                {
                    additionsSum += commit.Additions;
                    deletionsSum += commit.Deletions;

                    Console.WriteLine("    commit {0}: {1} ({2} additions, {3} deletions)",
                        commit.Hash,
                        commit.Message,
                        commit.Additions,
                        commit.Deletions);
                }

                Console.WriteLine($"    Total: {additionsSum} additions, {deletionsSum} deletions");

                additionsSum = 0m;
                deletionsSum = 0m;
            }
        }
    }
}