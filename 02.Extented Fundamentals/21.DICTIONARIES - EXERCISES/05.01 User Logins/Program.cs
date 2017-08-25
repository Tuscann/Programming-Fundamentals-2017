using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main() // 100/100
    {
        string input = Console.ReadLine();

        Dictionary<string, string> outputAnswer = new Dictionary<string, string>();

        while (input != "login")
        {
            string[] namesAndPasswords = input.Split(' ').ToArray();

            outputAnswer[namesAndPasswords[0]] = namesAndPasswords[2];

            input = Console.ReadLine();
        }

        input = Console.ReadLine();

        int wrongPass = 0;

        while (input != "end")
        {
            string[] namesAndPasswords = input.Split(' ').ToArray();

            if (outputAnswer.ContainsKey(namesAndPasswords[0]) &&outputAnswer[namesAndPasswords[0]] == namesAndPasswords[2])
            {
                Console.WriteLine($"{namesAndPasswords[0]}: logged in successfully");
            }
            else
            {
                Console.WriteLine($"{namesAndPasswords[0]}: login failed");
                wrongPass++;
            }

            input = Console.ReadLine();
        }
        Console.WriteLine("unsuccessful login attempts: {0}", wrongPass);
    }
}