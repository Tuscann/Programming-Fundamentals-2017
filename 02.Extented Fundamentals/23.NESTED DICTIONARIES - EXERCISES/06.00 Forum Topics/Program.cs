using System;
using System.Collections.Generic;
using System.Linq;
public class Program
{
    public static void Main() // 100/100
    {
        Dictionary<string, HashSet<string>> forumTopicsData = new Dictionary<string, HashSet<string>>();
        string currentLine = Console.ReadLine();

        while (currentLine != "filter")
        {
            string[] currentData = currentLine
                .Split(new[] { " -> ", ", " }, StringSplitOptions.RemoveEmptyEntries);
            string topic = currentData[0];
            string[] tags = currentData.Skip(1).ToArray();

            if (!forumTopicsData.ContainsKey(topic))
            {
                forumTopicsData[topic] = new HashSet<string>();
            }

            AddTagsToTopic(forumTopicsData, topic, tags);

            currentLine = Console.ReadLine();
        }

        string[] filteredTags = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

        PrintTopicsWithFilteredTags(forumTopicsData, filteredTags);
    }

    static void AddTagsToTopic(
        Dictionary<string, HashSet<string>> forumTopicsData, string topic, string[] tags)
    {
        foreach (string tag in tags)
        {
            forumTopicsData[topic].Add($"#{tag}");
        }
    }

    static void PrintTopicsWithFilteredTags(
        Dictionary<string, HashSet<string>> forumTopicsData, string[] filteredTags)
    {
        foreach (KeyValuePair<string, HashSet<string>> topic in forumTopicsData)
        {
            bool containsAllTags = true;

            foreach (string tag in filteredTags)
            {
                if (!topic.Value.Contains($"#{tag}"))
                {
                    containsAllTags = false;
                }
            }

            if (containsAllTags)
            {
                Console.WriteLine($"{topic.Key} | {string.Join(", ", topic.Value)}");
            }
        }
    }
}