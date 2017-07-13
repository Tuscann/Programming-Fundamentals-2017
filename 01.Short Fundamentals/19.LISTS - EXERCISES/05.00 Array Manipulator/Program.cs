using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        while (true)
        {
            List<string> curent = Console.ReadLine().Split(' ').ToList();

            if (curent[0] == "print")
            {
                Console.WriteLine("[{0}]", string.Join(", ", input));
                break;
            }
            if (curent[0] == "add")
            {
                int index = int.Parse(curent[1]);
                int element = int.Parse(curent[2]);

                input.Insert(index, element);
            }
            if (curent[0] == "addMany")
            {
                int index = int.Parse(curent[1]);
                List<int> listToAdd = new List<int>();

                for (int i = 2; i < curent.Count; i++)
                {
                    listToAdd.Add(int.Parse(curent[i]));
                }
                input.InsertRange(index, listToAdd);

            }
            if (curent[0] == "contains")
            {
                int serachedNumber = int.Parse(curent[1]);
                Console.WriteLine(input.IndexOf(serachedNumber));
            }
            if (curent[0] == "remove")
            {
                int removedNumber = int.Parse(curent[1]);

                input.RemoveAt(removedNumber);
            }
            if (curent[0] == "shift")
            {
                int rotations = int.Parse(curent[1]);
                List<int> list = new List<int>();

                for (int i = 0; i < input.Count; i++)
                {
                    if (i < rotations)
                    {
                        list.Add(input[i]);
                        input.Remove(input[i]);
                    }
                }
                input.AddRange(list);
            }
            if (curent[0] == "sumPairs")
            {
                List<int> sums = new List<int>();
                for (int i = 0; i < input.Count; i += 2)
                {
                    if (i + 1 < input.Count)
                        sums.Add(input[i] + input[i + 1]);
                    else
                        sums.Add(input[i]);
                }
                input = sums;
            }
        }
    }
}