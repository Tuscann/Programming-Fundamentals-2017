using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        var dic = new Dictionary<char, int>();

        string input = Console.ReadLine();

        foreach (var letter in input)
        {
            if (!dic.ContainsKey(letter))
            {
                dic[letter] = 1;
            }
            else
            {
                dic[letter]++;
            }
        }
        foreach (var charr in dic)
        {
            Console.WriteLine("{0} -> {1}", charr.Key, charr.Value);
        }
    }
}