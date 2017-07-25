using System;
using System.Text.RegularExpressions;
class Program
{
    static void Main()  // 80/100
    {
        string searched = Console.ReadLine();
        string input = Console.ReadLine();
        //string pattern = "([A-Za-z0-9 -]+ " + searched + " [A-Za-z0-9 -]+[!|.|?])";
        string pattern = $@"[a-zA-Z0-9,\s]+ {searched} [a-zA-Z0-9,\s\-]+"; 

        Regex regex = new Regex(pattern);
        MatchCollection matches = regex.Matches(input);

        foreach (var match in matches)
        {
            var x = match.ToString().Trim();

            Console.WriteLine(x);
        }
    }
}