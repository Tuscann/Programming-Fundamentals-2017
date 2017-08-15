using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class Program
{
    static void Main()
    {
        List<string> messages = new List<string>();
        List<string> broadcasts = new List<string>();

        while (true)
        {
            string curennt = Console.ReadLine();
            if (curennt == "Hornet is Green")
            {
                break;
            }
            string[] stringSeparators = { " <-> " };

            string[] tokens = curennt.Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries);

            if (tokens.Length >= 2)
            {
                string leftPart = tokens[0];
                string rightPart = tokens[1];
                if (leftPart.All(char.IsDigit) && rightPart.All(char.IsLetterOrDigit))
                {
                    char[] reversingLeftPart = leftPart.ToCharArray().Reverse().ToArray();
                    string reversed = string.Join("", reversingLeftPart);
                    string message = $"{reversed} -> {rightPart}";
                    messages.Add(message);
                }
                else if (leftPart.All(c => !char.IsDigit(c)) && rightPart.All(char.IsLetterOrDigit))
                {
                    StringBuilder result = new StringBuilder();

                    foreach (char t in rightPart)
                    {
                        if (char.IsUpper(t))
                        {
                            result.Append(char.ToLower(t));
                        }
                        else if (char.IsLower(t))
                        {
                            result.Append(char.ToUpper(t));
                        }
                        else
                        {
                            result.Append(t);
                        }
                    }

                    string broadcast = $"{result} -> {leftPart}";
                    broadcasts.Add(broadcast);
                }
            }
        }
        Console.WriteLine("Broadcasts:");

        if (broadcasts.Count == 0)
        {
            Console.WriteLine("None");
        }
        else
        {
            Console.WriteLine(string.Join(Environment.NewLine, broadcasts));
        }
        Console.WriteLine("Messages:");
        if (messages.Count  == 0)
        {
            Console.WriteLine("None");
        }
        else
        {
            Console.WriteLine(string.Join(Environment.NewLine, messages));
        }
    }
}