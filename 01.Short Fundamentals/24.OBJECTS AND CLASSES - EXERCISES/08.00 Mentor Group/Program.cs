using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;  // 100/100

namespace _8.Mentor_Group
{
    class Program
    {
        static void Main()
        {
            var students = new List<Student>();
            string input = Console.ReadLine();
            while (input != "end of dates")
            {
                var tokens = input.Split(new char[] { ' ', ',' }).ToArray();
                var name = tokens[0];

                List<DateTime> currDates  = new List<DateTime>();
                foreach (var date in tokens.Skip(1))
                {
                    var localTokens = date.Split('/').ToArray();
                    int year = int.Parse(localTokens[2]);
                    int month = int.Parse(localTokens[1]);
                    int day = int.Parse(localTokens[0]);
                    currDates.Add(new DateTime(year, month, day));
                }

                if (students.Any(x=>x.name == name))
                {
                    students.Single(x => x.name == name).dates.AddRange(currDates);
                }
                else
                {
                    var currStudent = new Student(name);
                    currStudent.dates.AddRange(currDates);
                    students.Add(currStudent);
                }
                              
                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            while(input != "end of comments")
            {
                var tokens = input.Split('-').ToArray();
                var name = tokens[0];
                var comment = tokens[1];

                if(students.Any(x=>x.name == name))
                {
                    var studentsWithNames = students.Where(x => x.name == name).ToArray();

                    for (int i = 0; i < studentsWithNames.Length; i++)
                    {
                        studentsWithNames[i].comments.Add(comment);
                    }
                }
                input = Console.ReadLine();
            }

            foreach (var student in students.OrderBy(x=>x.name))
            {
                Console.WriteLine(student.name);
                Console.WriteLine("Comments:");
                foreach (var comm in student.comments)
                {
                    Console.WriteLine($"- {comm}");
                }
                Console.WriteLine("Dates attended:");
                foreach (var date in student.dates.OrderBy(x=>x))
                {
                    Console.WriteLine($"-- {date.ToString("dd/MM/yyyy")}");
                }
            }
            //Console.ReadLine();
        }
    }

    public class Student
    {
        public string name;
        public List<string> comments = new List<string>();
        public List<DateTime> dates = new List<DateTime>();

        public Student(string Name)
        {
            name = Name;
        }
    }
}