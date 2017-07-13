using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();
        string input = "";

        while ((input = Console.ReadLine()) != "print")
        {
            string[] commands = input.Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);

            switch (commands[0])
            {
                case "add":
                    {
                        int index = int.Parse(commands[1]);
                        int element = int.Parse(commands[2]);
                        if (index >= 0 && index <= numbers.Count)
                        {
                            numbers.Insert(index, element);
                        }
                        break;
                    }
                case "addMany":
                    {
                        int index = int.Parse(commands[1]);
                        int[] elements = new int[commands.Length - 2];
                        for (int i = 2; i < commands.Length; i++)
                        {
                            elements[i - 2] = int.Parse(commands[i]);
                        }
                        if (index >= 0 && index <= numbers.Count)
                        {
                            numbers.InsertRange(index, elements);
                        }
                        break;
                    }
                case "contains":
                    {
                        int element = int.Parse(commands[1]);
                        Console.WriteLine(numbers.IndexOf(element));
                        break;
                    }
                case "remove":
                    {
                        int index = int.Parse(commands[1]);
                        if (index >= 0 && index < numbers.Count)
                            numbers.RemoveAt(index);
                        break;
                    }
                case "shift":
                    {
                        int positions = int.Parse(commands[1]);
                        positions %= numbers.Count;
                        numbers = numbers
                            .Skip(positions)
                            .Concat(numbers.Take(positions))
                            .ToList();
                        break;
                    }
                case "sumPairs":
                    {
                        List<int> sums = new List<int>();
                        for (int i = 0; i < numbers.Count; i += 2)
                        {
                            if (i + 1 < numbers.Count)
                                sums.Add(numbers[i] + numbers[i + 1]);
                            else
                                sums.Add(numbers[i]);
                        }
                        numbers = sums;
                        break;
                    }
            }
        }
        Console.WriteLine("[{0}]", string.Join(", ", numbers));
    }
}
