using System;
using System.Collections.Generic;
using System.Linq;
public class ForumTopics
{
    static Dictionary<string, HashSet<string>> forumHistogram = new Dictionary<string, HashSet<string>>();

    public static void Main()
    {
        string currentLine = Console.ReadLine();

        while (currentLine != "filter")
        {
            string[] splited = currentLine.Split(new[] { " -> ", ", " }, StringSplitOptions.RemoveEmptyEntries);
            string topic = splited[0];
            string[] tags = splited.Skip(1).ToArray();

            if (!forumHistogram.ContainsKey(topic))
            {
                forumHistogram[topic] = new HashSet<string>();
            }
            AddRange(forumHistogram, topic, tags);

            currentLine = Console.ReadLine();
        }

        string[] filters = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
        PrintMatchedTopics(forumHistogram, filters);
    }

    static void AddRange(Dictionary<string, HashSet<string>> forumHistogram, string topic, string[] tags)
    {
        foreach (string tag in tags)
        {
            forumHistogram[topic].Add($"#{tag}");
        }
    }

    static void PrintMatchedTopics(Dictionary<string, HashSet<string>> forumHistogram, string[] filters)
    {
        foreach (KeyValuePair<string, HashSet<string>> topic in forumHistogram)
        {
            bool contains = true;
            foreach (string tag in filters)
            {
                if (!topic.Value.Contains($"#{tag}"))
                {
                    contains = false;
                }
            }
            if (contains)
            {
                Console.WriteLine($"{topic.Key} | {string.Join(", ", topic.Value)}");
            }
        }
    }
}