using System;
using System.Collections.Generic;
using System.Linq;
public class FixEmails
{
    public static void Main()
    {
        string name = Console.ReadLine();
        string[] domain = { "uk", "us" };
        Dictionary<string, string> nameAndEmails = new Dictionary<string, string>();

        while (!name.Equals("stop"))
        {
            string email = Console.ReadLine();

            if (!nameAndEmails.ContainsKey(name))
            {
                nameAndEmails.Add(name, null);
            }

            nameAndEmails[name] = email;
            name = Console.ReadLine();
        }
        nameAndEmails
           .Where(kvp => !kvp.Value.EndsWith(domain[0]))
           .Where(kvp => !kvp.Value.EndsWith(domain[1]))
           .ToDictionary(x => x.Key, x => x.Value);

        foreach (var key in nameAndEmails)
        {
            Console.WriteLine($"{key.Key} -> {key.Value}");
        }
    }
}