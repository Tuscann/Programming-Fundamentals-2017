using System;
class Program
{
    static void Main()
    {
        int counter = int.Parse(Console.ReadLine());

        string lastbracket = string.Empty;
        string print = "BALANCED";

        for (int i = 0; i < counter; i++)
        {
            string curentrow = Console.ReadLine();

            if (curentrow == "(")
            {
                if (lastbracket == "(")
                {
                    print = "UNBALANCED";
                    break;
                }
                lastbracket = "(";
            }
            else if (curentrow == ")")
            {
                if (lastbracket != "(")
                {
                    print = "UNBALANCED";
                    break;
                }
                lastbracket = ")";
            }
        }
        if (lastbracket == "(")
        {
            print = "UNBALANCED";
        }
        Console.WriteLine(print);
    }
}