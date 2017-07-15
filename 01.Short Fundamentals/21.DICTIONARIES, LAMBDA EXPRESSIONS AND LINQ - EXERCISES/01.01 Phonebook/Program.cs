using System;
using System.Collections.Generic;
class Phonebook
{
    static void Main()
    {
        Dictionary<string, string> phonebook = new Dictionary<string, string>();
        string[] inputDetails = Console.ReadLine().Split();

        while (inputDetails[0] != "END")
        {
            if (inputDetails.Length == 3) //add to the dict if have 3 strings
            {
                phonebook[inputDetails[1]] = inputDetails[2];
            }
            else //find
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
            inputDetails = Console.ReadLine().Split();
        }
    }

}