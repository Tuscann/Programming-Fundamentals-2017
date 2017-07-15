using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        List<string> lineOfStrings = Console.ReadLine().ToLower().Split().ToList();

        Dictionary<string, int> answer = new Dictionary<string, int>();

        foreach (string word in lineOfStrings)
        {
            if (answer.ContainsKey(word))
            {
                answer[word]++;
            }
            else
            {
                answer[word] = 1;
            }
        }
        string solution = string.Empty;

        foreach (KeyValuePair<string, int> kvp in answer)
        {
            if (kvp.Value % 2 == 1)
            {
                solution += kvp.Key;
                solution += ", ";
            }
        }
        string realSolution = solution.Remove(solution.Length - 2, 2); // remove dot and space

        Console.WriteLine(realSolution);
    }
}
