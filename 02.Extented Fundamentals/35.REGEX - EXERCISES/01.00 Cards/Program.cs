using System;
using System.Text.RegularExpressions;
class Program
{
    static void Main()   // 60/100
    {
        string input = Console.ReadLine();
        //string pattern = @"[2|3|4|5|6|7|8|9|10|J|Q|K|A]*[S|H|D|C]{1}";
        //string pattern = @"(10 |[2 - 9] |[JQKA])[SHDC]";
        //string pattern = @"([1]?[0-9AJKQ])([SHDC])";
        string pattern = @"([2-9][SHDC])|([JQKA][SHDC])|(10[SHDC])";

        MatchCollection matches = Regex.Matches(input, pattern);

        for (int i = 0; i < matches.Count; i++)
        {
            if (i == matches.Count - 1)
            {
                Console.WriteLine("{0}", matches[i]);
                break;
            }
            Console.Write("{0}, ", matches[i]);
        }
    }
}