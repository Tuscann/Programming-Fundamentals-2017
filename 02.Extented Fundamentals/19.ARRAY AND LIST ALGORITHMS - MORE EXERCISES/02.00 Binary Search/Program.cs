using System;
using System.Collections.Generic;
using System.Linq;
class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();
            int number = int.Parse(Console.ReadLine());

            if (input.Contains(number))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] == number)
                {
                    Console.WriteLine("Linear search made {0} iterations", i + 1);
                }
            }
            input.Sort();
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] == number)
                {
                    Console.WriteLine("Binary search made {0} iterations", i + 1);
                }
            }
        }
    }