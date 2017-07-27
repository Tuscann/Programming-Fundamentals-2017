using System;
using System.Text;
public class Karate_Strings
{
    public static void Main()  // 100/100
    {
        StringBuilder input = new StringBuilder(Console.ReadLine());

        char punch = '>';
        int punchStrength = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == punch)
            {
                punchStrength += int.Parse(input[i + 1].ToString());

                i++;

                while (i < input.Length && punchStrength > 0)
                {
                    if (input[i] == punch)
                    {
                        break;
                    }

                    input.Remove(i, 1);
                    punchStrength--;
                }

                i--;
            }
        }
        Console.WriteLine(input);
    }
}