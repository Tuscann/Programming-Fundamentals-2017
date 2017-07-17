using System;
using System.Collections.Generic;
public class User
{
    public User(string name)
    {
        this.Name = name;
        this.Position = string.Empty;
        this.Age = -1;
        this.Salary = -1;
    }

    public string Name { get; }

    public string Position { get; set; }

    public int Age { get; set; }

    public double Salary { get; set; }

    public override string ToString()
    {
        return $"Name: {this.Name}";
    }
}

public class Program
{
    private static void Main()
    {
        string input = Console.ReadLine();
        Dictionary<string, User> withPosition = new Dictionary<string, User>();
        Dictionary<string, User> withSalary = new Dictionary<string, User>();
        Dictionary<string, User> withAge = new Dictionary<string, User>();

        while (input != "filter base")
        {
            string[] tokens = input.Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            string username = tokens[0];
            bool isAge = int.TryParse(tokens[1], out int age);
            bool isSalary = double.TryParse(tokens[1], out double salary);

            User user = new User(username);

            if (isAge)
            {
                user.Age = age;
                withAge.Add(username, user);
            }
            else if (isSalary)
            {
                user.Salary = salary;
                withSalary.Add(username, user);
            }
            else
            {
                user.Position = tokens[1];
                withPosition.Add(username, user);
            }
            input = Console.ReadLine();
        }
        input = Console.ReadLine();

        if (input == "Position")
        {
            foreach (KeyValuePair<string, User> user in withPosition)
            {
                Console.WriteLine(user.Value);
                Console.WriteLine($"Position: {user.Value.Position}");
                Console.WriteLine(new string('=', 20));
            }
        }
        else if (input == "Salary")
        {
            foreach (KeyValuePair<string, User> user in withSalary)
            {
                Console.WriteLine(user.Value);
                Console.WriteLine($"Salary: {user.Value.Salary:F2}");
                Console.WriteLine(new string('=', 20));
            }
        }
        else
        {
            foreach (KeyValuePair<string, User> user in withAge)
            {
                Console.WriteLine(user.Value);
                Console.WriteLine($"Age: {user.Value.Age}");
                Console.WriteLine(new string('=', 20));
            }
        }
    }
}