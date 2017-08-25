using System;
using System.Text.RegularExpressions;
class Program
{
    static void Main() // 100/100
    {
        var input = Console.ReadLine();

        string patter = @"name:""([A-z]{1,})"",age:([0-9]*),grades:\[([0-9, ]*)\]}";

        var matches = Regex.Matches(input, patter);

        foreach (Match match in matches)
        {
            string username = match.Groups[1].Value;
            string age = match.Groups[2].Value;
            string grades = match.Groups[3].Value;

            Console.Write("{0} : {1} -> ", username, age);
            if (grades == "")
            {
                Console.WriteLine("None");
            }
            else
            {
                Console.WriteLine(grades);
            }
        }
    }
}