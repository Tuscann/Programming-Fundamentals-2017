using System;
using System.Text.RegularExpressions;
class Program
{
    static void Main() //100/100
    {
        string word = Console.ReadLine();
        string sentence = Console.ReadLine();

        string solution = Regex.Replace(sentence, $@"{word}", new string('*', word.Length));
        Console.WriteLine(solution);
    }
}