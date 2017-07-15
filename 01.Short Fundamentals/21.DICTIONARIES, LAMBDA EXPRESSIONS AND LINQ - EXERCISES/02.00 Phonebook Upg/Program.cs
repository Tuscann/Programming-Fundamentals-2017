using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        SortedDictionary<string, string> dict = new SortedDictionary<string, string>();

        while (true)
        {
            string[] command = Console.ReadLine().Split(' ').ToArray();
            
            if (command[0] == "A")
            {
                string name = command[1];
                string phoneNumber = command[2];

                dict[name] = phoneNumber;  // презаписване или добавяне
            }
            else if (command[0] == "S")
            {
                if (dict.ContainsKey(command[1]))
                {
                    Console.WriteLine("{0} -> {1}", command[1], dict[command[1]]);
                }
                else
                {
                    Console.WriteLine("Contact {0} does not exist.", command[1]);
                }
            }
            else if (command[0] == "ListAll")
            {
                foreach (var name in dict)
                {
                    Console.WriteLine("{0} -> {1}", name.Key, name.Value);
                }
            }
            else if (command[0] == "END")
            {
                break;
            }
        }
    }
}