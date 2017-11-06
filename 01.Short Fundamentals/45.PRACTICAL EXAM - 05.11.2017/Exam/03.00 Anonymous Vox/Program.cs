using System;
using System.Text.RegularExpressions;   // 100/100
class AnonymousVox
{
    static void Main()
    {
        string text = Console.ReadLine();
        
        string[] placeholders = Console.ReadLine().Split(new char[] { '{', '}' }, StringSplitOptions.RemoveEmptyEntries);
        
        string pattern = @"([a-zA-Z]+)(.+)\1";
        Regex regex = new Regex(pattern);
        MatchCollection matches = regex.Matches(text);
        
        int placeholderIndex = 0;
       
        foreach (Match match in matches)
        {
            if (placeholderIndex >= placeholders.Length)
            {
                break;     //If the placeholders are more than the values, then we break.
            }
            text = ReplaceFirst(text, match.Groups[2].Value, placeholders[placeholderIndex++]);
        }
        Console.WriteLine(text);
    }
    static string ReplaceFirst(string text, string oldValue, string newValue)
    {
        string substringWithOldValue = text.Substring(0, text.IndexOf(oldValue) + oldValue.Length);

        string substringWithNewValue = substringWithOldValue.Replace(oldValue, newValue);

        return substringWithNewValue + text.Substring(substringWithOldValue.Length);
    }
}