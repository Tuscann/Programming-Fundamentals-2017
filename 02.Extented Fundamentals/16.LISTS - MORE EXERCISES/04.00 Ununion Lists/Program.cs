using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        int counter = int.Parse(Console.ReadLine());

        for (int i = 0; i < counter; i++)
        {
            List<int> curentList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            for (int j = 0; j < curentList.Count; j++)
            {
                bool lamp = true;
                for (int k = 0; k < input.Count; k++)
                {
                    if (curentList[j] == input[k])
                    {
                        input.RemoveAt(k);
                        k--;
                        lamp = false;
                    }
                    else if (k == input.Count - 1 && lamp)
                    {
                        input.Add(curentList[j]);
                        break;
                    }
                }
            }
        }
        input.Sort();
        Console.WriteLine(string.Join(" ", input));
    }
}