using System;
using System.Collections.Generic;
using System.Linq;
public class Program
{
    public static void Main()  // 100/100
    {
        List<string> shootedTargets = new List<string>();
        string parameters = Console.ReadLine();
        string inputLine = Console.ReadLine();

        var tokens = parameters.Split().Select(int.Parse).ToArray();
        int n = tokens[0];
        int m = tokens[1];
        int index = inputLine.IndexOf("\\<<<");

        while (index != -1)
        {
            inputLine = inputLine.Substring(index + 4);
            int indexOfNextCannon = inputLine.IndexOf("\\<<<");

            if (indexOfNextCannon < n + m && indexOfNextCannon > 0)
            {
                string between = inputLine.Substring(0, indexOfNextCannon);
                var newOneShort = between.Skip(n).Take(m).ToList();
                shootedTargets.Add(string.Join("", newOneShort));
            }
            else
            {
                var newOneLong = inputLine.Skip(n).Take(m).ToList();
                shootedTargets.Add(string.Join("", newOneLong));
            }

            index = inputLine.IndexOf("\\<<<");
        }

        for (int i = 0; i < shootedTargets.Count; i++)
        {
            if (shootedTargets[i] == string.Empty)
            {
                shootedTargets.RemoveAt(i);
                i--;
            }
        }
        Console.WriteLine(string.Join("/\\", shootedTargets));
    }
}