using System;
using System.Text;
using System.Text.RegularExpressions;
public class Key_Replacer
{
    public static void Main()  // 100/100
    {
        var key = Console.ReadLine();
        var text = Console.ReadLine();

        var keysPattern = @"^(?<startKey>[a-zA-Z]*)(?:\<|\||\\)(?:.+)(?:\<|\||\\)(?<endKey>[a-zA-Z]*)$";

        var keyMatch = Regex.Match(key, keysPattern);

        if (keyMatch.Success)
        {
            var startKey = keyMatch.Groups["startKey"].Value;
            var endKey = keyMatch.Groups["endKey"].Value;

            var textPattern = $@"{startKey}(?<word>.*?){endKey}";
            var matches = Regex.Matches(text, textPattern);

            var result = new StringBuilder();

            foreach (Match match in matches)
            {
                result.Append(match.Groups["word"].Value);
            }

            Console.WriteLine(result.ToString().Length == 0 ? "Empty result" : result.ToString());
        }
    }
}