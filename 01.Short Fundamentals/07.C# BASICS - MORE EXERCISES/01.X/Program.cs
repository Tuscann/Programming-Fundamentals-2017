using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int before = 0;
        int middle = n - 2;

        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine("{0}x{1}x{0}", new string(' ', before), new string(' ', middle));
            before++;
            middle -= 2;
        }
        Console.WriteLine("{0}x{0}", new string(' ', n / 2));
        for (int i = n / 2; i > 0; i--)
        {
            before--;
            middle += 2;
            Console.WriteLine("{0}x{1}x{0}", new string(' ', before), new string(' ', middle));
        }
    }
}