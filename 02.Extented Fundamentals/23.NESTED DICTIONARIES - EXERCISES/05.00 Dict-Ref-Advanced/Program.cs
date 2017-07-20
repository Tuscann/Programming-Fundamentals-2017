using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()   // 100/100
    {
        Dictionary<string, List<int>> dic = new Dictionary<string, List<int>>();

        while (true)
        {
            string breakk = Console.ReadLine();
            if (breakk == "end")
            {
                break;
            }
            List<string> currentRow = breakk.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToList();

            string name = currentRow[0];

            int number = 0;
            List<string> values = currentRow[1].Split(new[] { ",", ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            bool isValue = int.TryParse(values[0], out number);

            if (isValue)
            {
                if (!dic.ContainsKey(name))
                {
                    dic[name] = new List<int>();
                }
                dic[name].AddRange(values.Select(int.Parse));
            }
            else
            {
                string secoundName = currentRow[1];

                foreach (var names in dic)
                {
                    if (names.Key == secoundName)
                    {
                        dic[name] = new List<int>(dic[names.Key]);   //refrence type data is dictionary
                        break;
                    }
                }
            }
        }
        foreach (KeyValuePair<string, List<int>> name in dic)
        {
            Console.WriteLine("{0} === {1}", name.Key, string.Join(", ", name.Value));
        }
    }
}