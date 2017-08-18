using System;
class Program
{
    static void Main()  // 100/100
    {
        string country = Console.ReadLine();

        switch (country)
        {
            case "USA":
            case "England":
                Console.WriteLine("English"); break;
            case "Spain":
            case "Argentina":
            case "Mexico":
                Console.WriteLine("Spanish"); break;
            default: Console.WriteLine("unknown"); break;
        }
    }
}