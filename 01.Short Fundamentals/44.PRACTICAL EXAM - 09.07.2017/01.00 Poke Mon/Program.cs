using System;
class Program
{
    static void Main()
    {
        decimal firstN = decimal.Parse(Console.ReadLine());
        decimal seccoundM = decimal.Parse(Console.ReadLine());
        int thirdY = int.Parse(Console.ReadLine());
        decimal start = firstN / 2;

        int counter = 0;
        while (true)
        {
            firstN -= seccoundM;
            counter++;
            if (thirdY != 0)
            {
                if (start == firstN)
                {
                    firstN /= thirdY;
                }
            }
            if (firstN < seccoundM)
            {
                break;
            }
        }
        Console.WriteLine(Math.Floor(firstN));
        Console.WriteLine(counter);
    }
}