using System;
using System.Collections.Generic;
using System.Linq;
public class Shellbound
{
    public static void Main()       // 100/100
    { 
        string inputLine = Console.ReadLine();
        Dictionary<string, HashSet<int>> regions = new Dictionary<string, HashSet<int>>();

        while (inputLine != "Aggregate")
        {
            string[] tokens = inputLine.Split();

            string region = tokens[0];
            int shell = int.Parse(tokens[1]);

            if (!regions.ContainsKey(region))
            {
                regions[region] = new HashSet<int>();
            }
            regions[region].Add(shell);

            inputLine = Console.ReadLine();
        }
        foreach (var regionAndShell in regions)
        {
            string region = regionAndShell.Key;
            HashSet<int> shell = regionAndShell.Value;

            Console.WriteLine($"{region} -> {string.Join(", ", shell)} ({Math.Ceiling(shell.Sum() - shell.Average())})");
        }
    }
}