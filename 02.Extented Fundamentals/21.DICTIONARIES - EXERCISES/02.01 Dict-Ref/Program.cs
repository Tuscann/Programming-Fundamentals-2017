using System;
using System.Collections.Generic;
using System.Linq;
public class DictRef
{
    public static void Main()
    {
        string input = Console.ReadLine();

        Dictionary<string, int> result = new Dictionary<string, int>();
        List<string> inputList = new List<string>();

        while (input != "end")
        {
            inputList = input.Split(new char[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string firstElement = inputList[0];
            string lastElement = inputList[inputList.Count - 1];

            int number = 0;

            if (int.TryParse(lastElement, out number))
            {
                result[firstElement] = number;
            }
            else
            {
                if (result.ContainsKey(lastElement))
                {
                    int referencedValue = result[lastElement];
                    result[firstElement] = referencedValue;
                }
            }
            input = Console.ReadLine();
        }
        foreach (KeyValuePair<string, int> kvp in result)
        {
            string key = kvp.Key;
            int value = kvp.Value;

            Console.WriteLine($"{key} === {value}");
        }
    }
}