using System;
using System.Text;
using System.Text.RegularExpressions;
class CubicMessages
{
    static void Main() // 100/100
    {
        Regex rgx1 = new Regex(@"^\d+([a-zA-Z]+)[^a-zA-Z]*$");

        string command = Console.ReadLine().Trim();

        while (command != "Over!")
        {
            int charNumber = int.Parse(Console.ReadLine());

            if (rgx1.IsMatch(command))
            {
                string rawMsg = rgx1.Match(command).Groups[1].ToString();
                if (rawMsg.Length == charNumber)
                {
                    MatchCollection digits = Regex.Matches(command.Trim(), @"\d");

                    StringBuilder sb = new StringBuilder();
                    foreach (Match digitMatch in digits)
                    {
                        int indx = int.Parse(digitMatch.Value);
                        if (indx > rawMsg.Length - 1)
                        {
                            sb.Append(" ");
                        }
                        else
                        {
                            sb.Append(rawMsg[indx]);
                        }
                    }
                    Console.WriteLine($"{rawMsg} == {sb}");
                }
            }
            command = Console.ReadLine().Trim();
        }
    }
}