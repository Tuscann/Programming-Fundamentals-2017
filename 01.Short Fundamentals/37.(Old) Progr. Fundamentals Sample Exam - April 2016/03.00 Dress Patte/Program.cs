using System;
class Program
{
    static void Main() // 100/100
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}.{0}.{0}", new String('_', 4 * n));

        int dashiesbefore = 4 * n - 2;
        int dotsinside = 2;
        int midle = 4 * n - 2;

        for (int i = 0; i < 2 * n - 1; i++)
        {
            Console.WriteLine("{0}.{1}.{2}.{1}.{0}", new String('_', dashiesbefore)
                , new String('*', dotsinside), new String('_', midle));
            dashiesbefore -= 2;
            dotsinside += 3;
            midle -= 2;


        }
        Console.WriteLine(".{0}..{0}.", new String('*', (12 * n - 2) / 2));

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(".{0}.", new String('*', 12 * n));
        }
        Console.WriteLine("{0}{1}{0}", new String('.', 3 * n), new String('*', 6 * n + 2));
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{0}{1}{0}", new String('_', 3 * n), new String('o', 6 * n + 2));
        }

        int before = 3 * n;
        int inside = 6 * n;

        for (int i = 0; i < 3 * n; i++)
        {
            Console.WriteLine("{0}.{1}.{0}", new String('_', before), new String('*', inside));
            before--;
            inside += 2;
        }
        Console.WriteLine("{0}", new String('.', 12 * n + 2));
    }
}