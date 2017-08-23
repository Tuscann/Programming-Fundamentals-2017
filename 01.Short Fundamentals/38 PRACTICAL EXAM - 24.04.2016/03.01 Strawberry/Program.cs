using System;
class Program
{
    static void Main() // 100/100
    {
        int n = int.Parse(Console.ReadLine());
        int width = 2 * n + 3;
        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine("{1}\\{0}|{0}/{1}", new string('-', n - 2 * i), new string('-', i * 2));
        }
        int dotCount = 1;
        for (int i = 0; i < n / 2 + 1; i++)
        {
            Console.WriteLine("{0}#{1}#{0}", new string('-', n - 2 * i), new string('.', dotCount));
            dotCount += 4;
        }
        for (int i = 0; i < n + 1; i++)
        {
            Console.WriteLine("{0}#{1}#{0}", new string('-', i), new string('.', width - 2 - 2 * i));
        }
    }
}