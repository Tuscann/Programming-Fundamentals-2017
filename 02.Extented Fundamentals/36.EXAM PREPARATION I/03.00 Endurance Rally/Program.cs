using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()  // 100/100
    {
        List<string> names = Console.ReadLine().Split().ToList();
        List<decimal> numbers = Console.ReadLine().Split().Select(decimal.Parse).ToList();
        List<decimal> positions = Console.ReadLine().Split().Select(decimal.Parse).ToList();

        foreach (string name in names)
        {
            decimal sum = 0;
            char firstLetter = name[0];
            int firstInteger = firstLetter;

            int zone = 0;
            bool isReached = true;

            sum += firstInteger;

            for (int i = 0; i < numbers.Count; i++)
            {
                foreach (decimal position in positions)
                {
                    if (i == position)
                    {
                        sum += numbers[i] * 2;
                        break;
                    }
                }
                sum -= numbers[i];

                if (sum <= 0)
                {
                    isReached = false;
                    break;
                }
                zone++;
            }
            if (isReached)
            {
                Console.WriteLine("{0} - fuel left {1:f2}", name, sum);
            }
            else
            {
                Console.WriteLine("{0} - reached {1}", name, zone);
            }
        }
    }
}