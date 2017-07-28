using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
class Program
{
    static void Main()  // 100/100 no ne minava nuleviq test
    {
        var dic = new List<string>();

        while (true)
        {
            string current = Console.ReadLine();
            string empty = String.Empty;

            if (current == "stringify")
            {
                break;
            }
            string pattern = @"([A-z]{1,}) : ([0-9]*) -> ([0-9]*,?[0-9, ]*)";

            MatchCollection matches = Regex.Matches(current, pattern);
            
            foreach (Match match in matches)
            {
                string name = match.Groups[1].Value;
                string age = match.Groups[2].Value;
                string grades = match.Groups[3].Value;
               
                empty += "{name:\"" + name + "\",age:" + age + ",grades:[" + grades + "]}";

                dic.Add(empty);
            }
        }
        Console.Write("[");
        Console.Write("{0}",string.Join(",",dic));
        Console.Write("]");
    }
}