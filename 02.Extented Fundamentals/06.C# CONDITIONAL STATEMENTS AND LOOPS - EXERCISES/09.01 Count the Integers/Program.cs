using System;
class P09_CountTheIntegers
{
    static void Main() // 100/100
    {
        int numCount = 0;
        while (true)
        {
            try
            {
                int.Parse(Console.ReadLine());
                numCount++;

            }
            catch (OverflowException)
            {
                break;
            }
            catch (FormatException)
            {
                break;
            }
        }

        Console.WriteLine(numCount);
    }
}