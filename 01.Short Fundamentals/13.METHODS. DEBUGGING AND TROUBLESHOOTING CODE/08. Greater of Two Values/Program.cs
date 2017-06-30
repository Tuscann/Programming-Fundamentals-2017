using System;
class Program
{
    static string compareStrings(string first, string secound)
    {
        if (first.CompareTo(secound) >= 0)
        return first;
        return secound;
    }
    static int compareInt(string first, string secound)
    {
        if (int.Parse(first) >= int.Parse(secound))
        {
            return int.Parse(first);
        }
        else
        {
            return int.Parse(secound);
        }
    }
    static char compareChars(string first, string secound)
    {
        return char.Parse(first) > char.Parse(secound)? char.Parse(first): char.Parse(secound);

    }
    static void Main()
    {
        string type = Console.ReadLine();
        string first = Console.ReadLine();
        string secound = Console.ReadLine();

        if (type == "string")
        {
            string max = compareStrings(first, secound);
            Console.WriteLine(max);
        }
        else if (type == "int")
        {
            int max = compareInt(first, secound);
            Console.WriteLine(max);
        }
        else if (type == "char")
        {
            char max = compareChars(first, secound);
            Console.WriteLine(max);
        }
    }
}