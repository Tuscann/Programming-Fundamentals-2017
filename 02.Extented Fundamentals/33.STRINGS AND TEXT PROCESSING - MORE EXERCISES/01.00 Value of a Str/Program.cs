using System;
public class Program
{
    public static void Main() // 100/100
    {
        char[] inputChars = Console.ReadLine().ToCharArray();
        string command = Console.ReadLine();

        int sum = 0;

        foreach (var ch in inputChars)
        {
            if (command == "UPPERCASE")
            {
                if (ch > 64 && ch < 91)
                {
                    sum += ch;
                }
            }
            else if (command == "LOWERCASE")
            {
                if (ch > 96 && ch < 123)
                {
                    sum += ch;
                }
            }
        }

        Console.WriteLine($"The total sum is: {sum}");
    }
}