using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (var i = 1; i <= 4; i++)
        {
            for (var k = 1; k <= 4; k++)
            {
                for (var l = 1; l <= 4; l++)
                {
                    var preSufix = n > i + k + l ? "X" : "O";
                    var firstChar = i == 1 ? "A" : i == 2 ? "C" : i == 3 ? "G" : "T";
                    var secondChar = k == 1 ? "A" : k == 2 ? "C" : k == 3 ? "G" : "T";
                    var thirdChar = l == 1 ? "A" : l == 2 ? "C" : l == 3 ? "G" : "T";

                    if (l > 1)Console.Write(" ");

                    Console.Write(preSufix + firstChar + secondChar + thirdChar + preSufix);
                }
                Console.WriteLine();
            }
        }
    }
}