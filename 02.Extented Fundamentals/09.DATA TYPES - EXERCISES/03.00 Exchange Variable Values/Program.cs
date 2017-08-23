using System;
class ExchangeValues
{
    static void Main() // 100/100
    {
        int a = int.Parse(Console.ReadLine());
        var b = int.Parse(Console.ReadLine());

        int tempVariable = a;
        a = b;
        b = tempVariable;

        Console.WriteLine(a);
        Console.WriteLine(b);
    }
}