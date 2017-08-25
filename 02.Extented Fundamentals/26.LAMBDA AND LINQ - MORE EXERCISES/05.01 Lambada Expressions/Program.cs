using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main() // 100/100
    {
        string input = Console.ReadLine();

        Dictionary<string, string> lambadaDict = new Dictionary<string, string>();

        while (input != "lambada")
        {
            string[] tokens = input.Split(new string[] { " => " }, StringSplitOptions.RemoveEmptyEntries);

            if (tokens[0] == "dance")
            {
                var temp = lambadaDict.ToDictionary(pair => pair.Key, pair => pair.Value);

                foreach (var pair in temp)
                {
                    string[] value = temp[pair.Key].Split('.');
                    string selectorObject = value[0];
                    string modifiedText = selectorObject + ".";

                    lambadaDict[pair.Key] = modifiedText + lambadaDict[pair.Key];
                }
            }
            else
            {
                string selector = tokens[0];
                string objectAndProperty = tokens[1];

                lambadaDict[selector] = objectAndProperty;
            }

            input = Console.ReadLine();
        }

        foreach (KeyValuePair<string, string> pair in lambadaDict)
        {
            Console.WriteLine($"{pair.Key} => {pair.Value}");
        }
    }
}