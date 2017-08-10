using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
class Program
{
    static void Main() // 50/100
    {
        string[] intTokens = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string input = Console.ReadLine();
        var destroyedTargets = new List<string>();
        int distanceShoot = int.Parse(intTokens[0]);
        int elementsToDestroy = int.Parse(intTokens[1]);
        Regex pattern = new Regex(@"(?<=\\[<]{3})\w+");

        string[] text = pattern.Matches(input).Cast<Match>().Select(m => m.Value).ToArray();
        foreach (var line in text)
        {
            if (elementsToDestroy > line.Length - 1 - elementsToDestroy)
            {
                destroyedTargets.Add(line.Substring(distanceShoot));
            }
            else
            {
                destroyedTargets.Add(line.Substring(distanceShoot, elementsToDestroy));
            }
        }
        Console.WriteLine(string.Join("/\\", destroyedTargets));
    }
}