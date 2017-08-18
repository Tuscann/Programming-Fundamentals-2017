using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
class Program
{
    static void Main() // 100/100
    {
        while (true)
        {
            string line = Console.ReadLine();
            if (line == "Over!")
            {
                break;
            }

            int count = int.Parse(Console.ReadLine());
            Regex regex = new Regex($@"^(\d+)([a-zA-Z]{{{count}}})([^a-zA-Z]*)$");

            Match match = regex.Match(line);
            if (match.Success)
            {
                string left = match.Groups[1].Value;
                string message = match.Groups[2].Value;
                string right = match.Groups[3].Value;

                IEnumerable<int> indexes = string.Concat(left, right)
                    .Where(char.IsDigit)
                    .Select(s => s - '0');

                StringBuilder result = new StringBuilder();

                foreach (int index in indexes)
                {
                    if (index < 0 || index >= message.Length)
                    {
                        result.Append(' ');
                    }
                    else
                    {
                        result.Append(message[index]);
                    }
                }
                Console.WriteLine($"{message} == {result}");
            }
        }
    }
}