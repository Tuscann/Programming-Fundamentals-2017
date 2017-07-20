using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()            // 100/100
    {
        int totalGrades = int.Parse(Console.ReadLine());

        Dictionary<string, List<double>> solution = new Dictionary<string, List<double>>();

        for (int cycle = 0; cycle < totalGrades; cycle++)
        {
            string[] nameAndGrade = Console.ReadLine().Split().ToArray();

            if (!solution.ContainsKey(nameAndGrade[0]))
            {
                solution[nameAndGrade[0]] = new List<double>();
            }
            solution[nameAndGrade[0]].Add(double.Parse(nameAndGrade[1]));
        }
        foreach (var kvp in solution)
        {
            Console.Write($"{kvp.Key} -> ");

            foreach (var grade in kvp.Value)
            {
                Console.Write($"{grade:f2} ");
            }
            Console.WriteLine($"(avg: {kvp.Value.Average():f2})");
        }
    }
}