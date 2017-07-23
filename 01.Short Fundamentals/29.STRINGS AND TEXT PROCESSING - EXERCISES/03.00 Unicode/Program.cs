using System;
class Program
{
    static void Main()
    {
        var input = Console.ReadLine().ToCharArray();

        foreach (var charr in input)
        {
            Console.Write("\\u{0}", ((int)charr).ToString("x4"));
        }
    }
}