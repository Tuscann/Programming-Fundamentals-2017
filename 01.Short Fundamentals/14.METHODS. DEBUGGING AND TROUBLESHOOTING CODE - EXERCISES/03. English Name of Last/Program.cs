using System;
class Program  // 100/100
{
    static string lastDigit(long number)
    {
        string last = String.Empty;
        long lastDigit = number % 10;

        switch (lastDigit)
        {
            case 0: last = "zero"; break;
            case 1: last = "one"; break;
            case 2: last = "two"; break;
            case 3: last = "three"; break;
            case 4: last = "four"; break;
            case 5: last = "five"; break;
            case 6: last = "six"; break;
            case 7: last = "seven"; break;
            case 8: last = "eight"; break;
            case 9: last = "nine"; break;
        }
        return last;
    }

    static void Main()
    {
        long number = long.Parse(Console.ReadLine());

        string lastDigt = lastDigit(Math.Abs(number));
        Console.WriteLine(lastDigt);
    }
}