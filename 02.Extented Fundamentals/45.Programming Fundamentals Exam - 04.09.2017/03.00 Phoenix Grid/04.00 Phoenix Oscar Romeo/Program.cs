using System;
using System.Collections.Generic;  // 100/100
using System.Linq;
    class Program
    {
        static void Main()
        {
            Dictionary<string, HashSet<string>> data = new Dictionary<string, HashSet<string>>();

            string input = Console.ReadLine();

            while (input != "Blaze it!")
            {
                string[] myArr = input.Split(new string[] { " -> " }, StringSplitOptions.None);

                string creature = myArr[0];
                string squadMate = myArr[1];

                if (!data.ContainsKey(creature))
                {
                    data.Add(creature, new HashSet<string>());
                }

                if (creature != squadMate)
                {
                    data[creature].Add(squadMate);
                }

                input = Console.ReadLine();
            }

            Dictionary<string, List<string>> result = new Dictionary<string, List<string>>();

            foreach (KeyValuePair<string, HashSet<string>> item in data)
            {
                result.Add(item.Key, new List<string>());

                foreach (string mate in item.Value)
                {
                    if (data.ContainsKey(mate) && data[mate].Contains(item.Key))
                    {
                        continue;
                    }

                    else
                    {
                        result[item.Key].Add(mate);
                    }
                }
            }

            foreach (KeyValuePair<string, List<string>> item in result.OrderByDescending(c => c.Value.Count))
            {
                Console.WriteLine($"{item.Key} : {item.Value.Count}");
            }
        }
    }