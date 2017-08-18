using System;
using System.Collections.Generic;
using System.Linq;

    class P01_OrderByAge
    {
        static void Main() // 100/100
        {
            List<Person> people = new List<Person>();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] personInfo = command.Split(' ');
                string personName = personInfo[0];
                string personId = personInfo[1];
                int personAge = int.Parse(personInfo[2]);

                Person newPerson = new Person
                {
                    Name = personName,
                    IdTag = personId,
                    Age = personAge
                };
                people.Add(newPerson);

                command = Console.ReadLine();
            }

            people = people.OrderBy(p => p.Age).ToList();

            foreach (Person person in people)
            {
                Console.WriteLine($"{person.Name} with ID: {person.IdTag} is {person.Age} years old.");
            }
        }
    }

    class Person
    {
        public string Name { get; set; }
        public string IdTag { get; set; }
        public int Age { get; set; }
    }
