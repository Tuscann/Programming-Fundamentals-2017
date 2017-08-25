using System;
public class Program
{
    public static void Main()  // 100/100
    {
        string sentence = Console.ReadLine();
        string delimiter = Console.ReadLine();

        sentence = sentence.Replace(delimiter, "papoi");

        string[] elements = sentence.Split(new string[] { "papoi" }, StringSplitOptions.None);

        Console.WriteLine("[" + string.Join(", ", elements) + "]");
    }
}