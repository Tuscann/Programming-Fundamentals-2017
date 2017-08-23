using System;

class Calculator
{
    static void Main() // 100/100
    {
        int num1 = int.Parse(Console.ReadLine());
        char oper = char.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());

        double result = 0;

        switch (oper)
        {
            case '+':
                {
                    result = num1 + num2;
                    break;
                }
            case '-':
                {
                    result = num1 - num2;
                    break;
                }
            case '*':
                {
                    result = num1 * num2;
                    break;
                }
            case '/':
                {
                    result = num1 / num2;
                    break;
                }
        }
        Console.WriteLine("{0} {1} {2} = {3}", num1, oper, num2, result);
    }
}