using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
public class RegisterUsers
{
    public static void Main() // 100/100
    {
        List<Users> usersData = new List<Users>();

        string[] nameAndRegEntry = Console.ReadLine()
            .Split(new string[] { " -> " },
                StringSplitOptions.RemoveEmptyEntries);

        while (nameAndRegEntry[0] != "end")
        {
            string name = nameAndRegEntry[0];
            DateTime registrationDate = DateTime.ParseExact
                (nameAndRegEntry[1], "dd/MM/yyyy", CultureInfo.InvariantCulture);

            Users newUser = new Users
            {
                Name = name,
                RegistrationDate = registrationDate
            };
            usersData.Add(newUser);

            nameAndRegEntry = Console.ReadLine()
                .Split(new string[] { " -> " },
                    StringSplitOptions.RemoveEmptyEntries);
        }

        usersData.Reverse();
        usersData = usersData
            .OrderBy(r => r.RegistrationDate)
            .Take(5)
            .OrderByDescending(r => r.RegistrationDate)
            .ToList();

        foreach (var user in usersData)
        {
            Console.WriteLine(user.Name);
        }
    }
}

public class Users
{
    public string Name { get; set; }

    public DateTime RegistrationDate { get; set; }
}