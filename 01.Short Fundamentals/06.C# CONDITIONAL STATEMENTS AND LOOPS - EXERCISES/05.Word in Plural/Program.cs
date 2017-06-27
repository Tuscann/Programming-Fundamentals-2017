using System;
class Program
{
    static void Main()
    {
        string pruralNoun = Console.ReadLine();

        if (pruralNoun.Substring(pruralNoun.Length - 1) == "y")
        {
            pruralNoun = pruralNoun.Remove(pruralNoun.Length - 1);
            pruralNoun += "ies";
        }
        else if (pruralNoun.EndsWith("o") || pruralNoun.Substring(pruralNoun.Length - 1) == "s" || pruralNoun.Substring(pruralNoun.Length - 1) == "x" || pruralNoun.Substring(pruralNoun.Length - 1) == "z")
        {
            pruralNoun += "es";
        }
        else if (pruralNoun.Substring(pruralNoun.Length - 2) == "ch" || pruralNoun.Substring(pruralNoun.Length - 2) == "sh")
        {
            pruralNoun += "es";
        }
        else
        {
            pruralNoun += "s";
        }
        Console.WriteLine(pruralNoun);
    }
}