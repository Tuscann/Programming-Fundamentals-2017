using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;  // 60/100

class Student
{
    public string Name { get; set; }
    public List<string> Comments { get; set; }
    public List<DateTime> DatesAttend { get; set; }

}// end class Student
class Program
{
    static void Main(string[] args)
    {
        List<Student> myStudentsList = new List<Student>();
        Student myStudent = new Student();
        List<DateTime> myDates = new List<DateTime>();
        string str = Console.ReadLine().Trim();
        while (!(str == "end of dates"))
        {
             var arg = str.Split(' ').ToList();
            myStudent.Name = arg[0];
            if (arg.Count>1)
            {
                var dateStringAttend = arg[1].Split(',').ToList();
           
                foreach (var item in dateStringAttend)
                {
                    myDates.Add(DateTime.ParseExact(item, "dd/MM/yyyy", CultureInfo.InvariantCulture));
                }
                myStudent.DatesAttend = myDates;
            }
            myStudentsList.Add(myStudent);
            myDates = new List<DateTime>();
            myStudent = new Student();
            str = Console.ReadLine();
        }//end While end of dates reading
        str = Console.ReadLine();
        while (!(str == "end of comments"))
        {
            List<string> arg = str.Split('-').ToList();
            var commentName = arg[0];
            var commentNew = arg[1];
           
            foreach (var studentt in myStudentsList)
            {
                if (studentt.Name == commentName)
                {
                    if (studentt.Comments==null)
                    {
                        studentt.Comments = new List<string>();
                    }
                  //  var comment=commentNew;
                    studentt.Comments.Add(commentNew);
                }
            }
            str = Console.ReadLine();
        }// end while Comments
         List<Student> orderedByNameStudents=myStudentsList.OrderBy(s => s.Name).ToList();
        foreach (var student  in orderedByNameStudents)
        {
  
            Console.WriteLine(student.Name);
            Console.WriteLine("Comments:");
            List<string> listOfComments = student.Comments;
             if (listOfComments!=null)
             {
                foreach (var comment in listOfComments)
                {
                   Console.WriteLine("- {0}", comment);
                }
             }
            Console.WriteLine("Dates attended:");
            if (student.DatesAttend!=null) 
            {
                List<DateTime> dati = student.DatesAttend.OrderBy(s => s.Date).ToList();
                if (dati != null)
                {
                    foreach (var data in dati)
                    {
                        Console.WriteLine("-- " + data.ToString("dd/MM/yyyy"));
                    }
                }
            }
         
        }// end foreach
    }//end Main
}// end class Program