using System;
class P07_GreaterOfTwoValues
{
    static void Main()  // 100/100
    { 
        string dataType = Console.ReadLine();
        if (dataType == "string")
        {
            string value1 = Console.ReadLine();
            string value2 = Console.ReadLine();
            GetMaxValue(value1, value2);
        }
        if (dataType == "char")
        {
            char value1 = char.Parse(Console.ReadLine());
            char value2 = char.Parse(Console.ReadLine());
            GetMaxValue(value1, value2);
        }
        if (dataType == "int")
        {
            int value1 = int.Parse(Console.ReadLine());
            int value2 = int.Parse(Console.ReadLine());
            GetMaxValue(value1, value2);
        }
    }

    static void GetMaxValue(string value1, string value2)
    {
        Console.WriteLine(value1.CompareTo(value2) > 0 ?
            value1 :
            value2
        );
    }

    static void GetMaxValue(char value1, char value2)
    {
        Console.WriteLine(value1 > value2 ?
            value1 :
            value2
        );
    }

    static void GetMaxValue(int value1, int value2)
    {
        Console.WriteLine(value1 > value2 ?
            value1 :
            value2
        );
    }
}
