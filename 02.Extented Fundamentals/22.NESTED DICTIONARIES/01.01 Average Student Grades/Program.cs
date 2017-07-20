using System;
using System.Collections.Generic;
using System.Linq;
class AverageStudentGrades
{
    static void Main()
    {
        Dictionary<string, List<double>> allStudents = new Dictionary<string, List<double>>();
        int gradesCount = int.Parse(Console.ReadLine());

        for (int counter = 0; counter < gradesCount; counter++)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            string student = input[0];
            double grade = double.Parse(input[1]);

            if (!allStudents.ContainsKey(student))
            {
                allStudents.Add(student, new List<double>());
            }
            allStudents[student].Add(grade);
        }

        foreach (KeyValuePair<string, List<double>> student in allStudents)
        {
            string studentName = student.Key;
            List<double> grades = student.Value;
            double average = 0.0;
            average = CalculateAverage(grades, average);

            Console.Write("{0} -> ", studentName);
            for (int index = 0; index < grades.Count; index++)
            {
                Console.Write("{0:f2} ", grades[index]);
            }
            Console.WriteLine("(avg: {0:f2})", average);
        }
    }

    static double CalculateAverage(List<double> grades, double average)
    {
        int gradesCount = grades.Count;
        double sum = 0;

        for (int index = 0; index < grades.Count; index++)
        {
            sum += grades[index];
        }
        average = sum / gradesCount;
        return average;
    }
}
