using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
class Startup
{
    static void Main() // 100/100
    {
        Dictionary<string, List<string>> messages = new Dictionary<string, List<string>>();

        string privateKey = Console.ReadLine();
        
        Regex regex = new Regex(@"^TO:\s([A-Z]+);\sMESSAGE:\s(.+);$");

        string input = Console.ReadLine();

        while (input != "END")
        {
            if (regex.IsMatch(input))
            {
                int index = 0;
                Match match = regex.Match(input);

                string sender = match.Groups[1].ToString();

                if (!messages.ContainsKey(sender))
                {
                    messages.Add(sender, new List<string>());
                }

                string convertedMessage = "";

                for (int i = 0; i < match.Length; i++)
                {
                    if (index > privateKey.Length - 1)
                    {
                        index = 0;
                    }
                    int x = int.Parse(privateKey[index].ToString());
                    char letter = (char)(match.ToString()[i] + x);
                    convertedMessage += letter;
                    index++;
                }
                messages[sender].Add(convertedMessage);
            }
            input = Console.ReadLine();
        }

        foreach (var sender in messages.OrderBy(n => n.Key))
        {
            foreach (string item in sender.Value)
            {
                Console.WriteLine(item);
            }
        }
    }
}