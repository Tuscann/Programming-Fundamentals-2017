using System;
using System.Text.RegularExpressions;
class Program
{
    static void Main()  // 50/100
    {
        while (true)
        {
            string input = Console.ReadLine();

            if (input == "Traincode!")
            {
                break;
            }

            char[] charray = input.ToCharArray();

            if (charray[0] == '<' && charray[1] == '[' && charray[charray.Length - 2] == ']' && charray[charray.Length - 1] == '.')
            {
                string pattern = @"(\<\[[^A-Za-z0-9]{0,}\].)+(.\[[A-Za-z0-9]{0,}\].)*";

                Match match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    Console.WriteLine(input);
                }
            }
        }
    }
}