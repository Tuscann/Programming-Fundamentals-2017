using System;
class ASCIIString
{
    static void Main() // 100/100
    {
        int n = int.Parse(Console.ReadLine());
        string text = String.Empty;

        for (int i = 1; i <= n; i++)
        {
            ushort symbolWithNumber = ushort.Parse(Console.ReadLine());
            char symbol = (char)symbolWithNumber;

            text += symbol;
        }
        Console.WriteLine(text);
    }
}