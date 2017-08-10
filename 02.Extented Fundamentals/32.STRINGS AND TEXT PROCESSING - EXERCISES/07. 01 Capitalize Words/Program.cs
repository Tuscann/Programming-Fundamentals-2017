using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
class Program
{
    static void Main() // 60/100
    {
        int counter = 0;
        var dic = new Dictionary<int, List<string>>();
        while (true)
        {
            List<string> text = Console.ReadLine().Split().ToList();
            
            if (text[0] == "end")
            {
                break;
            }
            counter++;
            foreach (string element in text)
            {
                string otherElements = String.Empty;

                string word = element[0].ToString().ToUpper();
                bool s = Regex.IsMatch(word.ToString(), "[A-z\']", RegexOptions.IgnoreCase);
                if (s == false)
                {
                    continue;
                }

                for (int i = 1; i < element.Length; i++)
                {
                    bool isAlphaBet = Regex.IsMatch(element[i].ToString(), "[A-z\']", RegexOptions.IgnoreCase);
                    if (isAlphaBet)
                    {
                        otherElements += element[i].ToString().ToLower();
                    }
                }
                if (!dic.ContainsKey(counter))
                {
                    dic[counter] = new List<string>();
                }
                dic[counter].Add(word + otherElements);
            }
        }
        foreach (var word in dic)
        {
            for (int i = 0; i < word.Value.Count; i++)
            {
                if (i == word.Value.Count - 1)
                {
                    Console.Write("{0}", word.Value[i]);
                }
                else
                {
                    Console.Write("{0}, ", word.Value[i]);
                }
            }
            Console.WriteLine();
        }
    }
}