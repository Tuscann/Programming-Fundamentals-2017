using System;
class Program
{
    static void Main() // 100/100
    {
        string number = Console.ReadLine();
        int index = int.Parse(Console.ReadLine());

        FindNthDigit(number, index);
    }
    static void FindNthDigit(string number, int index)
    {
        for (int i = 0; i < number.Length; i++)
        {
            if (number.Length - index == i)
            {
                Console.WriteLine(number[i]);
                break;
            }
        }
    }
}