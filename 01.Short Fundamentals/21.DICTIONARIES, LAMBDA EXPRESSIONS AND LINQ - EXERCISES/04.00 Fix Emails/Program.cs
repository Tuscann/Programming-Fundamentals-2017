using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        var dict = new Dictionary<string, string>();
        while (true)
        {
            string person = Console.ReadLine();
            if (person == "stop")
            {
                break;
            }
            string email = Console.ReadLine();

            if (email.Contains(".us") || email.Contains(".uk"))
            {

            }
            else
            {
                dict.Add(person, email);
            }
        }
        foreach (var person in dict)
        {
            Console.WriteLine("{0} -> {1}", person.Key, person.Value);
        }
    }
}