using System;
using System.Text.RegularExpressions;
class Program
{
    static void Main()  // 100/100
    {
          string toRegex = @"(?<=\s)[a-z0-9]+([-.]\w*)*@[a-z]{1,}([-.]\w*)*(\.[a-z]{1,})";
        //string toRegex = @"(?<=\s)[a-z0-9]+([-.]\w*)*@[a-z]+([-.]\w*)*(\.[a-z]+)";
        //string toRegex = @"(?<=\s)[a-zA-Z0-9]+([-.]\w*)*@[a-zA-Z]+?([.-][a-zA-Z]*)*(\.[a-z]{2,})";
        
        var regexShmegex = new Regex(toRegex);
        string textToMatch = Console.ReadLine();

        var contains = regexShmegex.Matches(textToMatch);

        foreach (Match mail in contains)
        {
            Console.WriteLine(mail);
        }
    }
}