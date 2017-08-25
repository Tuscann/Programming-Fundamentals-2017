using System;
using System.Linq;
public class Program
{
    public static void Main() // 100/100
    {
        string line = Console.ReadLine();

        string passed = string.Empty;

        for (int i = 0; i < line.Length; i++)
        {
            if (!passed.Contains(line[i]))
            {
                string output = line[i] + ":";
                int index = 0;
                for (int j = 0; j < line.Length; j++)
                {
                    index = line.IndexOf(line[i], index);
                    if (index == -1)
                    {
                        break;
                    }

                    output += index + "/";
                    index++;
                }

                Console.WriteLine(output.Trim('/'));
                passed += line[i];
            }
        }
    }
}