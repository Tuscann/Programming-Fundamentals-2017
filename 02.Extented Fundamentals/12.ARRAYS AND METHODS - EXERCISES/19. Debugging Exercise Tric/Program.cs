using System;
class Debug_TrickyStrings
{
    static void Main() // 100/100
    {
        string delimiter = Console.ReadLine();
        int numberOfStrings = int.Parse(Console.ReadLine());

        string result = string.Empty;
        string currentString = string.Empty;

        for (int i = 1; i < numberOfStrings; i++)
        {
            currentString = Console.ReadLine();
            result += currentString + delimiter;
        }

        currentString = Console.ReadLine();
        result += currentString;
        Console.WriteLine(result);
    }
}