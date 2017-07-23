using System;
using System.Linq;
public class ReverseString
{
    public static void Main()
    {
        char[] readed = Console.ReadLine().ToCharArray();

        Console.WriteLine(string.Join("", readed.Reverse()));
    }
}