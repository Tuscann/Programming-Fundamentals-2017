using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._00_Pokemon_Don_t_Go
{
    class Program
    {
        static void Main()
        {
            List<int> input = Console.ReadLine().Split().Select(a => int.Parse(a)).ToList();

            int sum = 0;

            while (true)
            {
                int currentIndex = int.Parse(Console.ReadLine());

                if (currentIndex < 0)
                {
                    input.RemoveAt(0);
                    input.IndexOf(input.Last(), 0);
                    sum += input.Last();
                }
                else if (currentIndex > input.Count - 1)
                {
                    input.RemoveAt(input.Count - 1);
                    input.IndexOf(input.First(), input.Count - 1);
                    sum += input.First();
                }
                else
                {
                    sum += currentIndex;
                    input.RemoveAt(currentIndex);
                }


                for (int i = 0; i < input.Count; i++)
                {
                    if (input[i] < input[currentIndex])
                    {
                        input[i] += input[currentIndex];
                    }
                    else if (input[i] == input[currentIndex])
                    {

                    }
                    else if (input[i] > input[currentIndex])
                    {
                        input[i] -= input[currentIndex];
                    }
                }
                //input.RemoveAt(currentIndex);

                //Console.WriteLine();
                //Console.WriteLine(string.Join(" ", input));
                //Console.WriteLine();

                if (input.Count == 0)
                {
                    break;
                }


            }

            Console.WriteLine(sum);


        }
    }
}
