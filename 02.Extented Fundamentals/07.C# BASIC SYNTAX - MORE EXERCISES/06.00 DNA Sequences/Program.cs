using System;

class Program
{
    static void Main() // 100/100
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 4; i++)
        {
            for (int k = 1; k <= 4; k++)
            {
                for (int l = 1; l <= 4; l++)
                {
                    string preSufix = n > i + k + l ? "X" : "O";
                    string firstChar = i == 1 ? "A" : i == 2 ? "C" : i == 3 ? "G" : "T";
                    string secondChar = k == 1 ? "A" : k == 2 ? "C" : k == 3 ? "G" : "T";
                    string thirdChar = l == 1 ? "A" : l == 2 ? "C" : l == 3 ? "G" : "T";

                    if (l > 1)Console.Write(" ");

                    Console.Write(preSufix + firstChar + secondChar + thirdChar + preSufix);
                }
                Console.WriteLine();
            }
        }
    }
}