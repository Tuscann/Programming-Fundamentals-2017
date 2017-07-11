using System;
using System.Linq;
class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ').ToArray();
        int n = int.Parse(Console.ReadLine());
        string[] x = input;

        for (int i = 0; i < n; i++)
        {
            string[] current = Console.ReadLine().Split(' ').ToArray();
            if (current[0] == "Reverse")
            {
                x = x.Reverse().ToArray();
            }
            else if (current[0] == "Distinct")
            {
                x = x.Distinct().ToArray();
            }
            else if (current[0] == "Replace")
            {
                int index = int.Parse(current[1]);
                string word = current[2];

                for (int j = 0; j < x.Length - 1; j++)
                {
                    if (j == index)
                    {
                        x[j] = word;
                        break;
                    }
                }
            }
        }
        Console.WriteLine(string.Join(", ", x));
    }
}