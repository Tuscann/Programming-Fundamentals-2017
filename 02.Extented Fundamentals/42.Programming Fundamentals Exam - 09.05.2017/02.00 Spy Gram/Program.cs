using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
class Program
{
    static void Main() // 40/100
    {
        var key = Console.ReadLine();
        var pattern = @"^(TO)\:\s([A-Z]+)\;\s(MESSAGE)\:\s(.+)\;$";
        var inputLine = Console.ReadLine();
        var output = new List<string>();
        var outputEncrypt = new List<string>();
        Regex regex = new Regex(pattern);
        while (inputLine != "END")
        {
            if (regex.IsMatch(inputLine))
            {
                output.Add(inputLine);
            }

            inputLine = Console.ReadLine();
        }
        var outputForEncoding = output.OrderBy(x => x).ToList();
        
        for (int i = 0; i < outputForEncoding.Count; i++)
        {
            var curentWord = "";
            var c = 0;

            for (int j = 0; j < outputForEncoding[i].Length; j++)
            {
                char leter = (char)(outputForEncoding[i][j] + int.Parse(key[c].ToString()));

                if ((int)(leter) > 126)
                {
                    leter = (char)((int)(leter) - 126 + 32 - 1);
                }
                curentWord += leter;

                if (c == key.Length - 1)
                {
                    c = -1;
                }
                c++;
            }
            outputEncrypt.Add(curentWord);

        }
        foreach (string message in outputEncrypt)
        {
            Console.WriteLine(message);
        }
    }
}
