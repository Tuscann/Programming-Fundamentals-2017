using System;
class Program
{
    static void Main()
    {
        int counter = int.Parse(Console.ReadLine());

        int countOpen = 0;
        int countClose = 0;
        bool falsee = false;

        for (int i = 1; i <= counter; i++)
        {
            string curentrow = Console.ReadLine();

            if (curentrow == "(")
            {
                countOpen++;
                if (countOpen == countClose + 2)
                {
                    Console.WriteLine("UNBALANCED");
                    falsee = true;
                    break;
                }
                if (countClose == countOpen + 2)
                {
                    Console.WriteLine("UNBALANCED");
                    falsee = true;
                    break;
                }
            }
            else if (curentrow == ")")
            {
                countClose++;
                if (countOpen == countClose + 2)
                {
                    Console.WriteLine("UNBALANCED");
                    falsee = true;
                    break;
                }
                if (countClose == countOpen + 2)
                {
                    Console.WriteLine("UNBALANCED");
                    falsee = true;
                    break;
                }

            }
        }
        if (falsee == false)
        {
            if (countOpen == countClose)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}