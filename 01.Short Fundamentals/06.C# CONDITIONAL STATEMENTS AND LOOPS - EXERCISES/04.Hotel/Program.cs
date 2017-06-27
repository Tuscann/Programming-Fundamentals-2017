using System;
class Program
{
    static void Main()
    {
        string month = Console.ReadLine();
        decimal nights = decimal.Parse(Console.ReadLine());

        decimal discount = 1;

        if (month == "May")
        {
            if (nights > 7)
            {
                discount = 0.95m;
            }
            Console.WriteLine("Studio: {0:f2} lv.", nights * 50 * discount);
            Console.WriteLine("Double: {0:f2} lv.", nights * 65);
            Console.WriteLine("Suite: {0:f2} lv.", nights * 75);

        }
        else if (month == "October")
        {
            if (nights > 7)
            {
                discount = 0.95m;
                Console.WriteLine("Studio: {0:f2} lv.", (nights - 1) * 50 * discount);
            }
            else
            {
                Console.WriteLine("Studio: {0:f2} lv.", nights * 50);
            }
            Console.WriteLine("Double: {0:f2} lv.", nights * 65);
            Console.WriteLine("Suite: {0:f2} lv.", nights * 75);
        }
        else if (month == "June")
        {

            Console.WriteLine("Studio: {0:f2} lv.", nights * 60);
            if (nights > 14)
            {
                Console.WriteLine("Double: {0:f2} lv.", nights * 72m * 0.90m);
            }
            else
            {
                Console.WriteLine("Double: {0:f2} lv.", nights * 72);
            }
            Console.WriteLine("Suite: {0:f2} lv.", nights * 82);
        }
        else if (month == "September")
        {
            if (nights > 14)
            {
                Console.WriteLine("Studio: {0:f2} lv.", (nights - 1) * 60);
                discount = 0.90m;
            }
            else if (nights > 7 && nights <= 14)
            {
                Console.WriteLine("Studio: {0:f2} lv.", (nights - 1) * 60);
            }
            else
            {
                Console.WriteLine("Studio: {0:f2} lv.", nights * 60);
            }
            Console.WriteLine("Double: {0:f2} lv.", nights * 72m * discount);
            Console.WriteLine("Suite: {0:f2} lv.", nights * 82);
        }
        else
        {
            Console.WriteLine("Studio: {0:f2} lv.", nights * 68);
            Console.WriteLine("Double: {0:f2} lv.", nights * 77);
            if (nights > 14)
            {
                discount = 0.85m;
            }
            Console.WriteLine("Suite: {0:f2} lv.", nights * 89 * discount);
        }
    }
}