using System;

    public class P03_EmployeeData
    {
        public static void Main() // 100/100
        {
            var employeeName = Console.ReadLine();
            var employeeAge = int.Parse(Console.ReadLine());
            var employeeID = int.Parse(Console.ReadLine());
            var employeeSalary = double.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {employeeName}\n"
                              + $"Age: {employeeAge}\n"
                              + $"Employee ID: {employeeID.ToString("00000000")}\n"
                              + $"Salary: {employeeSalary.ToString("0.00")}");
        }
    }
