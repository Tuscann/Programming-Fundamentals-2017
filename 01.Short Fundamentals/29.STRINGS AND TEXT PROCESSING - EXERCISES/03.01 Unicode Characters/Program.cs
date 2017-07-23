using System;
using System.Text;
class Program
{
    static void Main()
    {
        char[] word = Console.ReadLine().ToCharArray();

        StringBuilder solution = new StringBuilder();
        foreach (char c in word)
        {
            solution.AppendFormat("\\u{0:x4}", (int)c);
        }

        Console.WriteLine(solution);
    }
}
