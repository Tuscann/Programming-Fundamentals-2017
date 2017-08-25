using System;
public class Nilapdromes
{
    public static void Main()  // 100/100
    {
        string input = Console.ReadLine();

        while (input != "end")
        {
            string borderFirst = input.Substring(0, input.Length / 2);
            string borderSecond = string.Empty;
            string border = string.Empty;

            if (input.Length % 2 == 0)
            {
                borderSecond = input.Substring(borderFirst.Length, input.Length - borderFirst.Length);
            }
            else
            {
                borderSecond = input.Substring(borderFirst.Length + 1, input.Length - borderFirst.Length - 1);
            }

            while (true)
            {
                if (borderFirst == borderSecond)
                {
                    border = borderFirst;
                    break;
                }
                if (borderFirst != borderSecond)
                {
                    borderFirst = borderFirst.Substring(0, borderFirst.Length - 1);
                    borderSecond = borderSecond.Substring(1, borderSecond.Length - 1);
                }

                if (borderFirst.Length == 0 && borderSecond.Length == 0)
                {
                    break;
                }
            }

            if (border.Length != 0)
            {
                string core = input.Remove(input.Length - border.Length, border.Length).Trim();
                core = core.Remove(0, border.Length).Trim();
                if (core != "")
                {
                    string nilapdromes = core + border + core;
                    Console.WriteLine(nilapdromes);
                }
            }

            input = Console.ReadLine();
        }
    }
}