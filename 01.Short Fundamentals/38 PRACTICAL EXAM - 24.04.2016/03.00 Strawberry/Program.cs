using System;
class Program
{
    static void Main() // 100/100
    {
        int n = int.Parse(Console.ReadLine());

        int before = 0;
        int inside = n;

        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine("{0}\\{1}|{1}/{0}", new string('-', before), new string('-', inside));
            before += 2;
            inside -= 2;
        }

        before = n;
        inside = 1;

        for (int i = 0; i < n / 2 + 1; i++)
        {
            Console.WriteLine("{0}#{1}#{0}", new string('-', before), new string('.', inside));
            before -= 2;
            inside += 4;
        }

        before = 0;
        inside = 2 * n + 1;

        for (int i = n; i >= 0; i--)
        {
            Console.WriteLine("{0}#{1}#{0}", new string('-', before), new string('.', inside));
            before += 1;
            inside -= 2;
        }
    }
}