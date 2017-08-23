using System;
class Strawberry
{
    static void Main() // 100/100
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine(new string('-', i * 2) + '\\' + new string('-', n - 2 * i) + '|' +
                              new string('-', n - 2 * i) + '/' + new string('-', i * 2));
        }
        Console.WriteLine(new string('-', n) + '#' + '.' + '#' + new string('-', n));
        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine(new string('-', n - 2 * i - 2) + '#' + new string('.', 5 + 4 * i) + '#' + new string('-', n - 2 * i - 2));
        }
        Console.WriteLine('#' + new string('.', 2 * n + 1) + '#');
        for (int i = n - 1; i >= 0; i--)
        {
            Console.WriteLine(new string('-', n - i) + '#' + new string('.', 2 * i + 1) + '#' + new string('-', n - i));
        }
    }
}