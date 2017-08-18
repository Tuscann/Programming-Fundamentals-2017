using System;
class P05_ForeignLanguages
{
    static void Main() //100/100
    {
        string country = Console.ReadLine();

        switch (country)
        {
            case "England":
            case "USA":
                Console.WriteLine("English");
                break;
            case "Spain":
            case "Argentina":
            case "Mexico":
                Console.WriteLine("Spanish");
                break;
            default:
                Console.WriteLine("unknown");
                break;
        }
    }
}