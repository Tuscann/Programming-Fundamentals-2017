using System;
class Program
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        for (int start = 2; start <= input; start++)
        {
            bool isPrime = true;
            for (int delimiter = 2; delimiter <= Math.Sqrt(start); delimiter++)
            {
                if (start % delimiter == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            Console.WriteLine($"{start} -> {isPrime}");
        }
    }
}
