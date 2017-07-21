using System;
class Program
{
    static void Main()
    {
        string[] words = Console.ReadLine().Split(' ');

        Random rnd = new Random();

        for (int pos1 = 0; pos1 < words.Length; pos1++)
        {
            int pos2 = rnd.Next(words.Length);

            string temp = words[pos1];
            words[pos1] = words[pos2];
            words[pos2] = temp;
        }
        Console.WriteLine(string.Join("\r\n", words));
    }
}