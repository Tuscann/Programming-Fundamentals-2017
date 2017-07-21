using System;
using System.Collections.Generic;
using System.Linq;
class Program
    {
        static void Main()   //100/100
    {
            Dictionary<string, Dictionary<string, long>> dic = new Dictionary<string, Dictionary<string, long>>();

            while (true)
            {
                string x = Console.ReadLine();
                if (x == "stop the game")
                {
                    break;
                }
                string[] current = x.Split('|');

                string team = current[1];
                string player = current[0];
                int pointsMade = int.Parse(current[2]);

                if (dic.ContainsKey(team))
                {
                    if (dic[team].Values.Count < 3)
                    {
                        if (dic[team].ContainsKey(player))
                        {
                            dic[team][player] += pointsMade;
                        }
                        else
                        {
                            dic[team].Add(player, pointsMade);
                        }
                    }
                }
                if (!dic.ContainsKey(team))
                {
                    dic[team] = new Dictionary<string, long>();
                    dic[team].Add(player, pointsMade);
                }
            }
            dic = dic.OrderByDescending(x => x.Value.Values.Sum()).ToDictionary(xa => xa.Key, xs => xs.Value);
            
            int counter = 1;
            foreach (KeyValuePair<string, Dictionary<string, long>> team in dic)
            {
                if (team.Value.Count == 3)
                {
                    Console.WriteLine("{0}. {1}; Players:", counter, team.Key);

                    foreach (KeyValuePair<string, long> pleyear in team.Value.OrderByDescending(x => x.Value))
                    {
                        Console.WriteLine("###{0}: {1}", pleyear.Key, pleyear.Value);
                    }
                    counter++;
                }
            }
        }
    }