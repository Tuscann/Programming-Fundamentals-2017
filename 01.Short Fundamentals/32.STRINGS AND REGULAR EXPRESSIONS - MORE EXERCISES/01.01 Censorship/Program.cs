using System;
class Program
{
    static void Main()    //100/100
    {
        string wordToReplace = Console.ReadLine();
        string sentence = Console.ReadLine();

        sentence = sentence.Replace(wordToReplace, new string('*', wordToReplace.Length));

        Console.WriteLine(sentence);
    }
}