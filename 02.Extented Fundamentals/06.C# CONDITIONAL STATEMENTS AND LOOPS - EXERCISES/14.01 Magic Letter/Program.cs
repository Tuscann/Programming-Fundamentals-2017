using System;

class P14_MagicLetter
{
    static void Main() // 100/100
    {
        char startChar = char.Parse(Console.ReadLine());
        char endChar = char.Parse(Console.ReadLine());
        char invalidChar = char.Parse(Console.ReadLine());

        for (char i = startChar; i <= endChar; i++)
        {
            if (i == invalidChar)
            {
                continue;
            }
            for (char j = startChar; j <= endChar; j++)
            {
                if (j == invalidChar)
                {
                    continue;
                }
                for (char k = startChar; k <= endChar; k++)
                {
                    if (k == invalidChar)
                    {
                        continue;
                    }
                    Console.Write($"{i}{j}{k} ");
                }
            }
        }
    }
}