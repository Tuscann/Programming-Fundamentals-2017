using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();

        string[] inputDetails = Console.ReadLine().Split();

        while (inputDetails[0] != "END")
        {
            if (inputDetails.Length == 3) //  add to the dict
            {
                phonebook[inputDetails[1]] = inputDetails[2];
            }
            else if (inputDetails.Length == 2) //  find
            {
                if (phonebook.ContainsKey(inputDetails[1]))
                {
                    Console.WriteLine($"{inputDetails[1]} -> {phonebook[inputDetails[1]]}");
                }
                else
                {
                    Console.WriteLine($"Contact {inputDetails[1]} does not exist.");
                }
            }
            else //  list all
            {
                foreach (var kvp in phonebook)
                {
                    Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
                }
            }
            inputDetails = Console.ReadLine().Split();
        }
    }
}