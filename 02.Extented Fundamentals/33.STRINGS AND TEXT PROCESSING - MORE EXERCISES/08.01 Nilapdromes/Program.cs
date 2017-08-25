using System;
public class Program
{
    public static void Main() // 100/100
    {
        string word = Console.ReadLine().ToLower();

        while (word != "end")
        {
            string frontBorder = string.Empty;
            string backBorder = string.Empty;
            string border = string.Empty;

            for (int i = 0; i < word.Length / 2; i++)
            {
                frontBorder = frontBorder + word[0 + i];
                backBorder = word[word.Length - 1 - i] + backBorder;
                if (frontBorder == backBorder)
                {
                    border = frontBorder;
                }
            }

            if (border.Length > 0)
            {
                string core = word
                    .Substring(border.Length, word.Length - (border.Length * 2));

                if (core.Length > 0)
                {
                    Console.WriteLine(core + border + core);
                }
            }

            word = Console.ReadLine();
        }
    }
}