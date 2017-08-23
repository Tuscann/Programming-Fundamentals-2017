using System;
public class TriplesofLatinLetters
{
    public static void Main() // 100/100
    {
        int n = int.Parse(Console.ReadLine());

        for (char a = 'a'; a < 'a' + n; a++)
        {
            for (char b = 'a'; b < 'a' + n; b++)
            {
                for (char c = 'a'; c < 'a' + n; c++)
                {
                    Console.WriteLine($"{a}{b}{c}");
                }
            }
        }
    }
}