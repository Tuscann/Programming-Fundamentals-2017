using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

public class CubicMessage
{
    static void Main() // 90/100
    {
        string message = Console.ReadLine();
        
        while (!message.Equals("Over!"))
        {
            int number = int.Parse(Console.ReadLine());
            Regex rgx = new Regex(@"^([0-9]+)([a-zA-Z]{" + number + @"})([^a-zA-Z]*)$");
            Match correctMsg = rgx.Match(message);

            if (correctMsg.Success)
            {
                string word = correctMsg.Groups[2].ToString();
                StringBuilder outputMsg = new StringBuilder();
                outputMsg.Append($"{word} == ");
                List<int> indexes = FindAllIndexes(correctMsg.Groups[1].ToString(), correctMsg.Groups[3].ToString());

                for (int i = 0; i < indexes.Count; i++)
                {
                    if (indexes[i] < 0 || indexes[i] >= word.Length)
                    {
                        outputMsg.Append(" ");
                    }
                    else
                    {
                        outputMsg.Append(word[indexes[i]]);
                    }
                }

                Console.WriteLine(outputMsg);
                outputMsg.Clear();
            }

            message = Console.ReadLine();
        }

    }

    private static List<int> FindAllIndexes(string leftGroup, string rightGroup)
    {
        List<int> indexes = new List<int>();
        for (int i = 0; i < leftGroup.Length; i++)
        {
            if (Char.IsDigit(leftGroup[i]))
            {
                indexes.Add(int.Parse(leftGroup[i].ToString()));
            }
        }

        for (int i = 0; i < rightGroup.Length; i++)
        {
            if (Char.IsDigit(rightGroup[i]))
            {
                indexes.Add(int.Parse(rightGroup[i].ToString()));
            }
        }

        return indexes;
    }
}