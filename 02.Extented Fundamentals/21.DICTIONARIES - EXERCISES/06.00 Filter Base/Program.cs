using System;
using System.Collections.Generic;
class Program
{
    static void Main() /// 100/100
    {
        string[] line = Console.ReadLine()
            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        Dictionary<string, int> age = new Dictionary<string, int>();
        Dictionary<string, decimal> salary = new Dictionary<string, decimal>();
        Dictionary<string, string> position = new Dictionary<string, string>();

        while (line[0] != "filter")
        {
            string name = line[0];
            string dataToStore = line[2];

            int employeeAge = 0;
            decimal employeeSalary = 0m;

            if (int.TryParse(dataToStore, out employeeAge))
            {
                if (!age.ContainsKey(name))
                {
                    age[name] = 0;
                }
                age[name] = employeeAge;
            }
            else if (decimal.TryParse(dataToStore, out employeeSalary))
            {
                if (!salary.ContainsKey(name))
                {
                    salary[name] = 0m;
                }
                salary[name] = employeeSalary;
            }
            else
            {
                if (!position.ContainsKey(name))
                {
                    position[name] = string.Empty;
                }
                position[name] = dataToStore;
            }

            line = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        }

        line = Console.ReadLine()
            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        switch (line[0])
        {
            case "Position":
                Print(position);
                break;
            case "Age":
                Print(age);
                break;
            case "Salary":
                Print(salary);
                break;
        }
    }

    static void Print(Dictionary<string, int> personData)
    {
        foreach (KeyValuePair<string, int> person in personData)
        {
            Console.WriteLine($"Name: {person.Key}");
            Console.WriteLine($"Age: {person.Value}");
            Console.WriteLine(new string('=', 20));
        }
    }

    static void Print(Dictionary<string, decimal> personData)
    {
        foreach (KeyValuePair<string, decimal> person in personData)
        {
            Console.WriteLine($"Name: {person.Key}");
            Console.WriteLine($"Salary: {person.Value:f2}");
            Console.WriteLine(new string('=', 20));
        }
    }

    static void Print(Dictionary<string, string> personData)
    {
        foreach (KeyValuePair<string, string> person in personData)
        {
            Console.WriteLine($"Name: {person.Key}");
            Console.WriteLine($"Position: {person.Value}");
            Console.WriteLine(new string('=', 20));
        }
    }
}