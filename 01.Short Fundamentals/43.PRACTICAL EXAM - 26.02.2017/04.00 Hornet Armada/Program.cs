using System;
using System.Collections.Generic;
using System.Linq;

public class SoldierInfo
{
    public int LastActivity { get; set; }
    public string LegionName { get; set; }
    public string Type { get; set; }
    public long Count { get; set; }
    public int Order { get; set; }
}

class Program
{
    static void Main() // 100/100
    {
        int n = int.Parse(Console.ReadLine());

        List<SoldierInfo> soldiers = new List<SoldierInfo>();
        Dictionary<string, int> activities = new Dictionary<string, int>();
        Dictionary<string, int> orders = new Dictionary<string, int>();
        int order = 0;

        for (int i = 0; i < n; i++)
        {
            string[] line = Console.ReadLine()
                .Split(new[] { ' ', '=', '-', '>', ':' }, StringSplitOptions.RemoveEmptyEntries);

            int lastActivity = int.Parse(line[0]);
            string legionName = line[1];
            if (!activities.ContainsKey(legionName)
                || activities[legionName] < lastActivity)
            {
                activities[legionName] = lastActivity;
            }

            order++;
            if (!orders.ContainsKey(legionName)
                || orders[legionName] > order)
            {
                orders[legionName] = order;
            }

            soldiers.Add(new SoldierInfo
            {
                LastActivity = activities[legionName],

                LegionName = legionName,

                Type = line[2],
                Count = long.Parse(line[3]),
                Order = order
            });
        }

        foreach (SoldierInfo soldierInfo in soldiers)
        {
            soldierInfo.LastActivity = activities[soldierInfo.LegionName];
            soldierInfo.Order = orders[soldierInfo.LegionName];
        }

        string command = Console.ReadLine();

        if (command.Contains("\\"))
        {
            string[] commandParts = command.Split('\\');
            int activity = int.Parse(commandParts[0]);
            string soldierType = commandParts[1];

            var result = soldiers.Where(s => s.Type == soldierType && s.LastActivity < activity)
                .GroupBy(s => s.LegionName).Select(gr => new
                {
                    LegionName = gr.Key,
                    Count = gr.Sum(s => s.Count),
                    Order = gr.Min(s => s.Order)
                })
                .OrderByDescending(s => s.Count).ThenBy(s => s.Order).ToList();

            foreach (var info in result)
            {
                Console.WriteLine($"{info.LegionName} -> {info.Count}");
            }
        }
        else
        {
            string soldierType = command;

            var result = soldiers.Where(s => s.Type == soldierType).GroupBy(s => s.LegionName)
                .Select(gr => new
                {
                    LegionName = gr.Key,
                    LastActivity = gr.Max(s => s.LastActivity),
                    Order = gr.Min(s => s.Order)

                })
                .OrderByDescending(s => s.LastActivity).ThenBy(s => s.Order).ToList();

            foreach (var info in result)
            {
                Console.WriteLine($"{info.LastActivity} : {info.LegionName}");
            }
        }
    }
}