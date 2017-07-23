using System;
class Program
{
    static void Main()
    {
        string text = Console.ReadLine().ToLower();
        string word = Console.ReadLine().ToLower();
        int count = 0;
        int lastIndex = -1;

        while (true)
        {
            int index = text.IndexOf(word, lastIndex + 1);
            if (index != -1)
            {
                count++;
                lastIndex = index;
            }
            else
            {
                break;
            }
        }
        Console.WriteLine(count);
    }
}