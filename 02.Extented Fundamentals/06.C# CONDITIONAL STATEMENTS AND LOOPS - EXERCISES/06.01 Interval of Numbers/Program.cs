using System;
class P06_IntervalOfNumbers
{
    static void Main() //100/100
    {
        byte number1 = byte.Parse(Console.ReadLine());
        byte number2 = byte.Parse(Console.ReadLine());
        byte smallerNumber = Math.Min(number1, number2);
        byte biggerNumber = Math.Max(number1, number2);

        for (int i = smallerNumber; i <= biggerNumber; i++)
        {
            Console.WriteLine(i);
        }
    }
}