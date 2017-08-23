using System;
class CypherRoulette
{
    static void Main() // 100/100
    {
        int n = int.Parse(Console.ReadLine());

        string result = String.Empty;
        int spinCounter = 0;
        string currentString;
        string previousString = String.Empty;
        int i = 1;

        while (i <= n)
        {
            currentString = Console.ReadLine();

            if (currentString == "spin")
            {
                if (currentString == previousString)
                {
                    result = String.Empty;
                }
                else
                {
                    spinCounter++;
                }
                previousString = currentString;
                continue;
            }

            if (currentString == previousString)
            {
                result = String.Empty;
            }
            else
            {
                if (spinCounter % 2 == 0)
                {
                    result += currentString;
                }
                else
                {
                    result = currentString + result;
                }
            }

            i++;
            previousString = currentString;
        }
        Console.WriteLine(result);
    }
}