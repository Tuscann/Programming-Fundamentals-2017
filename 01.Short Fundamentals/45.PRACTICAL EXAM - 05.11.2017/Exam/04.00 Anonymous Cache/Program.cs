using System;
using System.Collections.Generic;  // 100 /100
using System.Linq;
class AnonymousCache
{
    static void Main()
    {
        Dictionary<string, Dictionary<string, long>> data = new Dictionary<string, Dictionary<string, long>>();
        Dictionary<string, Dictionary<string, long>> cache = new Dictionary<string, Dictionary<string, long>>();

        string inputLine = string.Empty;

        while ((inputLine = Console.ReadLine()) != "thetinggoesskrra")
        {
            string[] inputParameters = inputLine.Split(new[] { ' ', '-', '>', '|' }, StringSplitOptions.RemoveEmptyEntries);

            if (inputParameters.Length == 1)  
            {
                string dataSet = inputParameters[0];
                
                if (cache.ContainsKey(dataSet))
                {
                    data[dataSet] = new Dictionary<string, long>(cache[dataSet]);
                    cache.Remove(dataSet);
                }
                else
                {
                    data[dataSet] = new Dictionary<string, long>();
                }
            }
            else
            {
                string dataKey = inputParameters[0];
                long dataSize = long.Parse(inputParameters[1]);
                string dataSet = inputParameters[2];

                //If the data does not contain such a dataSet we add it to the cache
                if (!data.ContainsKey(dataSet))
                {
                    //If the cache does not contain such a dataSet, we initialize the inner dictionary
                    //Otherwise we get null reference exception
                    if (!cache.ContainsKey(dataSet))
                    {
                        cache[dataSet] = new Dictionary<string, long>();
                    }

                    //Then we just add the key and size to the cache
                    cache[dataSet][dataKey] = dataSize;
                }
                else
                {
                    //If the data contains such a dataSet, we just add the key and the size to it
                    data[dataSet][dataKey] = dataSize;
                }
            }
        }
        if (data.Count > 0)
        {
            KeyValuePair<string, Dictionary<string, long>> result = data.OrderByDescending(ds => ds.Value.Sum(d => d.Value)).First();

            Console.WriteLine($"Data Set: {result.Key}, Total Size: {result.Value.Sum(d => d.Value)}");

            foreach (var value in result.Value)
            {
                Console.WriteLine("$.{0}", value.Key);
            }
        }
    }
}