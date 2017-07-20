using System;
using System.Collections.Generic;
using System.Linq;
public class Program
{
    public static void Main()  //  100/100
    {
        Dictionary<string, HashSet<string>> result = new Dictionary<string, HashSet<string>>();
        string input = Console.ReadLine();
        while (input != "filter")
        {
            List<string> inputParts = input.Split(new[] { '-', '>', ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            string topic = inputParts[0];
            List<string> tags = inputParts.Skip(1).ToList();

            if (!result.ContainsKey(topic))
            {
                result[topic] = new HashSet<string>();
            }
            foreach (string item in tags)
            {
                result[topic].Add(item);
            }
            input = Console.ReadLine();
        }
        List<string> tagsCheck = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();

        bool contained = false;
        foreach (string KVP in result.Keys)
        {
            for (int i = 0; i < tagsCheck.Count; i++)
            {
                if (result[KVP].Contains(tagsCheck[i]))
                {
                    contained = true;
                }
                else
                {
                    contained = false;
                }
                if (tagsCheck.Count >= 2 && contained == false)
                {
                    i = tagsCheck.Count + 1;
                }
            }
            if (contained)
            {
                Console.WriteLine($"{KVP} | #{string.Join(", #", result[KVP])}");
            }
        }
    }
}
