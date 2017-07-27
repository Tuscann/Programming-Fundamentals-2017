using System;
class Program
{
    static void Main() // 100/100
    {
        string inputString = Console.ReadLine();
        string outputString = string.Empty;
        int punchStrength = 0;
        for (int i = 0; i < inputString.Length; i++)
        {
            if (inputString[i] == '>')
            {
                punchStrength += int.Parse(inputString[i + 1].ToString());
            }
            else if (punchStrength > 0)
            {
                punchStrength--;
                continue;
            }
            outputString += inputString[i];
        }

        Console.WriteLine(outputString);
    }
}