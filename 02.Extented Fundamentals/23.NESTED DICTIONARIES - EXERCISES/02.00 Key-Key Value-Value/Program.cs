
using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main() // 100/100
    {
        Dictionary<string, List<string>> pairsData = new Dictionary<string, List<string>>();

        string key = Console.ReadLine();
        string value = Console.ReadLine();
        int lines = int.Parse(Console.ReadLine());

        for (int count = 0; count < lines; count++)
        {
            string[] currentLine = Console.ReadLine().Split(new[] { ' ', ';' });

            string currentKey = currentLine[0];
            IEnumerable<string> currentValues = currentLine.Skip(2);

            if (currentKey.Contains(key))
            {
                if (!pairsData.ContainsKey(currentKey))
                {
                    pairsData[currentKey] = new List<string>();
                }

                foreach (string val in currentValues)
                {
                    if (value.Contains(val) || val.Contains(value))
                    {
                        pairsData[currentKey].Add(val);
                    }
                }
            }
        }

        foreach (KeyValuePair<string, List<string>> item in pairsData)
        {
            Console.WriteLine("{0}:", item.Key);

            foreach (string element in item.Value)
            {
                Console.WriteLine("-{0}", element);
            }
        }
    }
}