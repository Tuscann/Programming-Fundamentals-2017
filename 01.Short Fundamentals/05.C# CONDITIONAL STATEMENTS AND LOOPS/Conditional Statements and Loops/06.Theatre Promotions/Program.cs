using System;
class Program
{
    static void Main(string[] args)
    {

        string typeOfDAY = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());
        int price = 0;

        if (age >= 0 && age <= 18)
        {
            if (typeOfDAY == "Weekday")
            {
                price = 12;
            }
            else if (typeOfDAY == "Weekend")
            {
                price = 15;
            }
            else if (typeOfDAY == "Holiday")
            {
                price = 5;
            }
            Console.WriteLine("{0}$", price);
        }
        else if (age > 18 && age <= 64)
        {
            if (typeOfDAY == "Weekday")
            {
                price = 18;
            }
            else if (typeOfDAY == "Weekend")
            {
                price = 20;
            }
            else if (typeOfDAY == "Holiday")
            {
                price = 12;
            }
            Console.WriteLine("{0}$", price);
        }
        else if (age > 64 && age <= 122)
        {
            if (typeOfDAY == "Weekday")
            {
                price = 12;
            }
            else if (typeOfDAY == "Weekend")
            {
                price = 15;
            }
            else if (typeOfDAY == "Holiday")
            {
                price = 10;
            }
            Console.WriteLine("{0}$",price);
        }
        else {
            Console.WriteLine("Error!");
        }
    }
}

