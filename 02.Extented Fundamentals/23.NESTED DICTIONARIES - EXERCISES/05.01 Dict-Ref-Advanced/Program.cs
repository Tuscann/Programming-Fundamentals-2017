using System;
using System.Collections.Generic;
using System.Linq;
public class DictRefAdvanced
{
    public static void Main()   // 100/100
    {
        Dictionary<string, List<string>> keysWithValues = new Dictionary<string, List<string>>();
        string curentLine = Console.ReadLine();
        while (curentLine != "end")
        {
            string[] splited = curentLine.Split(new[] { " -> ", "," }, StringSplitOptions.RemoveEmptyEntries);
            string key = splited[0];
            List<string> values = splited.Skip(1).ToList();

            int number = 0;
            bool isValue = int.TryParse(values[0], out number);
            if (!isValue && !keysWithValues.ContainsKey(values[0]))
            {
                curentLine = Console.ReadLine();
                continue;
            }
            if (!isValue && keysWithValues.ContainsKey(values[0]))
            {
                values = keysWithValues[values[0]];
            }

            if (!keysWithValues.ContainsKey(key))
            {
                keysWithValues[key] = new List<string>();
            }
            keysWithValues[key].AddRange(values);

            curentLine = Console.ReadLine();
        }

        foreach (KeyValuePair<string, List<string>> item in keysWithValues)
        {
            Console.Write($"{item.Key} === ");
            bool isFirst = true;
            foreach (string value in item.Value)
            {
                if (isFirst)
                {
                    isFirst = false;
                    Console.Write(value);
                    continue;
                }
                Console.Write(", {0}", value.TrimStart());
            }
            Console.WriteLine();
        }
    }
}