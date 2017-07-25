using System;
using System.Text.RegularExpressions;
class ReplaceAHrefTag
{
    static void Main() // 100/100
    {
        string text = Console.ReadLine();
        while (text != "end")
        {
            string pattern = @"<a.*?href.*?=(.*)>(.*?)<\/a>";
            string replacement = @"[URL href=$1]$2[/URL]";
            string replaced = Regex.Replace(text, pattern, replacement);
            Console.WriteLine(replaced);

            text = Console.ReadLine();
        }
    }
}