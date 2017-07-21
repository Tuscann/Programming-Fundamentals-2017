using System;
using System.Linq;
using System.Collections.Generic;
class FlattenDictionarySecond
{
    static void Main()  //100/100
    {
        Dictionary<string, Dictionary<string, string>> data = new Dictionary<string, Dictionary<string, string>>();
        Dictionary<string, List<string>> flattenedData = new Dictionary<string, List<string>>();

        string input = Console.ReadLine();
        while (input != "end")
        {
            string[] inputTokens = input.Split(' ');

            if (inputTokens[0] == "flatten")
            {
                string keyToFlatten = inputTokens[1];

                foreach (KeyValuePair<string, Dictionary<string, string>> record in data)
                {
                    string key = record.Key;
                    Dictionary<string, string> innerRecords = record.Value;
                    if (key == keyToFlatten)
                    {
                        foreach (KeyValuePair<string, string> innerRecord in innerRecords)
                        {
                            string flattenedValue = innerRecord.Key + innerRecord.Value;

                            if (!flattenedData.ContainsKey(key))
                            {
                                flattenedData.Add(key, new List<string>());
                            }
                            flattenedData[key].Add(flattenedValue);
                        }
                    }
                }

                data[keyToFlatten] = new Dictionary<string, string>();
            }
            else
            {
                string key = inputTokens[0];
                string innerKey = inputTokens[1];
                string innerValue = inputTokens[2];

                if (!data.ContainsKey(key))
                {
                    data.Add(key, new Dictionary<string, string>());
                }

                if (!data[key].ContainsKey(innerKey))
                {
                    data[key].Add(innerKey, "");
                }

                data[key][innerKey] = innerValue;
            }

            input = Console.ReadLine();
        }

        IOrderedEnumerable<KeyValuePair<string, Dictionary<string, string>>> orderedData = data.OrderByDescending(kvp => kvp.Key.Length);

        foreach (KeyValuePair<string, Dictionary<string, string>> record in orderedData)
        {
            string key = record.Key;
            Dictionary<string, string> innerRecords = record.Value;
            IOrderedEnumerable<KeyValuePair<string, string>> orderedInnerRecords = innerRecords.OrderBy(kvp => kvp.Key.Length);

            Console.WriteLine("{0}", key);

            int orderId = 1;
            foreach (KeyValuePair<string, string> innerRecord in orderedInnerRecords)
            {
                Console.WriteLine("{0}. {1} - {2}",
                    orderId,
                    innerRecord.Key,
                    innerRecord.Value);

                orderId++;
            }

            if (flattenedData.ContainsKey(key))
            {
                foreach (string flattenedValue in flattenedData[key])
                {
                    Console.WriteLine("{0}. {1}", orderId, flattenedValue);
                    orderId++;
                }
            }
        }
    }
}