using System;
using System.Linq;
class Program
{
    static void Main() // 100/100
    {
        int[] answer = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        bool isTriple = false;

        for (int arrayIndexer = 0; arrayIndexer < answer.Length; arrayIndexer++)
        {
            int a = answer[arrayIndexer];

            for (int checkDigit = arrayIndexer + 1; checkDigit < answer.Length; checkDigit++)
            {
                int b = answer[checkDigit];

                int sumOfTwoDigits = a + b;

                if (answer.Contains(sumOfTwoDigits))
                {
                    Console.WriteLine($"{a} + {b} == {sumOfTwoDigits}");
                    isTriple = true;
                }
            }
        }
        if (isTriple == false)
        {
            Console.WriteLine("No");
        }
    }
}