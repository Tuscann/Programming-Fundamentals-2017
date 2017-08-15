using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class BoomingCannon
{
    static void Main()
    {
        int[] cannonData = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int shotDistance = cannonData[0];
        int destroyedElements = cannonData[1];

        string inputString = Console.ReadLine();
        

        string targetPattern = @"(?<=\\[<]{3})\w+";

        MatchCollection targets = Regex.Matches(inputString, targetPattern);
        List<string> result = new List<string>();

        foreach (Match target in targets)
        {
            string destroyedTargets = target.Value.Substring(5 + shotDistance, destroyedElements);
            result.Add(destroyedTargets);
        }

        Console.WriteLine(string.Join(@"/\", result));
    }
}