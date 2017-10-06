using System;
class Program
{
    static void Main() // 100/100
    {
        int n = int.Parse(Console.ReadLine());
        if (n == 0)
        {
            Console.WriteLine(1);
        }
        else
        {
            Console.WriteLine(FiboMethod(n));
        }
    }

    static int FiboMethod(int n)
    {
        int a = 0;
        int b = 1;
        int answer = 0;

        for (int cycle = 0; cycle < n; cycle++)
        {
            answer = a + b;
            a = b;
            b = answer;
        }

        return answer;
    }
}