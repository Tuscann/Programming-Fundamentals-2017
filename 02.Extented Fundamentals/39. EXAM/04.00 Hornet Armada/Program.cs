using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main() // 80/100
    {

        var legionParams = new Dictionary<string, Dictionary<string, long>>();
        var legionActivity = new Dictionary<string, long>();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var inputInfo = Console.ReadLine();

            var firstSplit = inputInfo.Split(new char[] { ' ', '=', '-', '>', ':' }, StringSplitOptions.RemoveEmptyEntries);

            var lastActivity = long.Parse(firstSplit[0]);
            var legionName = firstSplit[1];
            var soldierType = firstSplit[2];
            var soldierCount = long.Parse(firstSplit[3]);


            if (!legionParams.ContainsKey(legionName))
            {
                legionParams[legionName] = new Dictionary<string, long>();
                legionActivity[legionName] = lastActivity;
            }

            if (!legionParams[legionName].ContainsKey(soldierType))
            {
                legionParams[legionName][soldierType] = 0;
            }

            legionParams[legionName][soldierType] += soldierCount;

            if (legionActivity[legionName] < lastActivity)
            {
                legionActivity[legionName] = lastActivity;
            }


        }

        var lastInput = Console.ReadLine().Split('\\');

        if (lastInput.Length < 2)
        {
            var currentSoldierType = lastInput[0];

            foreach (var legion in legionActivity.OrderByDescending(x => x.Value))
            {
                if (legionParams[legion.Key].ContainsKey(currentSoldierType))
                {
                    Console.WriteLine($"{legion.Value} : {legion.Key}");
                }
            }
        }
        else
        {
            var currentActicity = long.Parse(lastInput[0]);
            var currentSoldierType = lastInput[1];

            foreach (var legion in legionParams.OrderByDescending(x => x.Value[currentSoldierType]))
            {
                if (legionActivity[legion.Key] < currentActicity && legionParams[legion.Key].ContainsKey(currentSoldierType))
                {
                    Console.WriteLine($"{legion.Key} -> {legionParams[legion.Key][currentSoldierType]}");
                }
            }
        }
    }
}
