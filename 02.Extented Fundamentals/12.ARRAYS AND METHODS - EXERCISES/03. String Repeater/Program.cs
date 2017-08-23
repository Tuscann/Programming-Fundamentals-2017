using System;
class Program
{
    static void Main() // 100/100
    {
        string str = Console.ReadLine();
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine(RepeatString(str, number));
    }
    static string RepeatString(string str, int repeats)
    {
        string repeatedString = String.Empty;
        for (int i = 0; i < repeats; i++)
        {
            repeatedString += str;
        }
        return repeatedString;
    }
}
