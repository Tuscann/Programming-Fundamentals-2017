using System;
using System.Collections.Generic;
using System.Linq;
class MirrorImage
{
    static void Main() // 100/100
    {
        List<string> input = Console.ReadLine().Split(' ').ToList();
        string n = Console.ReadLine();
        ModifyTheList(input, n);
        Console.WriteLine(String.Join(" ", input));
    }

    static List<string> ModifyTheList(List<string> input, string n)
    {
        int lastPosition = input.Count - 1;

        while (n != "Print")
        {
            int number;
            bool isNumber = int.TryParse(n, out number);

            if (isNumber)
            {
                int index = number;
                lastPosition = input.Count - 1;

                int start = 0;
                int end = index / 2;
                for (int i = start; i < end; i++)
                {
                    string first = input[i];
                    string second = input[index - 1 - i];
                    input[i] = Swap(first, second).Item1;
                    input[index - 1 - i] = Swap(first, second).Item2;
                }

                start = index + 1;
                end = (start + lastPosition) / 2;
                for (int j = start; j <= end; j++)
                {
                    string first = input[j];
                    string second = input[lastPosition];
                    input[j] = Swap(first, second).Item1;
                    input[lastPosition] = Swap(first, second).Item2;
                    lastPosition--;
                }
            }
            n = Console.ReadLine();
        }
        return input;
    }

    static Tuple<string, string> Swap(string first, string second)
    {
        var temp = first;
        first = second;
        second = temp;
        return new Tuple<string, string>(first, second);
    }
}