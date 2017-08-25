using System;
using System.Collections.Generic;
using System.Linq;
public class IntegerInsertion
{
    public static void Main() // 100/100
    {
        List<int> inputListOfNumbers = Console.ReadLine().Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse).ToList();

        string stringNumbers = Console.ReadLine();
        stringNumbers = AddNumberAtIndexPosition(stringNumbers, inputListOfNumbers);

        Console.WriteLine(stringNumbers);
    }

    static string AddNumberAtIndexPosition(string stringNumbers, List<int> inputListOfNumbers)
    {
        while (stringNumbers != "end")
        {
            int number = 0;
            int.TryParse(stringNumbers, out number);
            int index = number;

            while (index > 10)
            {
                index /= 10;
            }

            if (index < 10 && index >= 0)
            {
                inputListOfNumbers.Insert(index, number);
            }

            stringNumbers = Console.ReadLine();
        }

        string result = string.Join(" ", inputListOfNumbers);

        return result;
    }
}