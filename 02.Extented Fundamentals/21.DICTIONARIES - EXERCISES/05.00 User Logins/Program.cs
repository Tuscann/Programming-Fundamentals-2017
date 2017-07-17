using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        var dic = new Dictionary<string, string>();
        int counter = 0;

        while (true)
        {
            var currentRow = Console.ReadLine().Split().ToList();

            if (currentRow[0] == "login")
            {
                break;
            }
            string username = currentRow[0];
            string password = currentRow[2];

            dic[username] = password;
        }
        while (true)
        {
            var currentRow = Console.ReadLine().Split().ToList();
            if (currentRow[0] == "end")
            {
                break;
            }
            string username = currentRow[0];
            string password = currentRow[2];

            if (!dic.ContainsKey(username))
            {
                Console.WriteLine("{0}: login failed", username);
                counter++;
            }
            if (dic.ContainsKey(username))
            {
                if (dic[username] == password)
                {
                    Console.WriteLine("{0}: logged in successfully",username);
                }
                else
                {
                    Console.WriteLine("{0}: login failed",username);
                    counter++;
                }
            }
        }
        Console.WriteLine("unsuccessful login attempts: {0}", counter);
    }
}