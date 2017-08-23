using System;
class GreaterOfTwoValues_2
{
    static void Main() // 100/100
    {
        string type = Console.ReadLine();

        if (type == "int")
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int greaterValue = GetGreater(num1, num2);
            Console.WriteLine(greaterValue);
        }
        else if (type == "char")
        {
            char ch1 = char.Parse(Console.ReadLine());
            char ch2 = char.Parse(Console.ReadLine());
            char greaterValue = GetGreater(ch1, ch2);
            Console.WriteLine(greaterValue);
        }
        else if (type == "string")
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            string greaterValue = GetGreater(str1, str2);
            Console.WriteLine(greaterValue);
        }
    }

    static int GetGreater(int num1, int num2)
    {
        int greater;

        if (num1 >= num2)
        {
            greater = num1;
        }
        else
        {
            greater = num2;
        }
        return greater;
    }

    static char GetGreater(char ch1, char ch2)
    {
        char greater;

        if (ch1 >= ch2)
        {
            greater = ch1;
        }
        else
        {
            greater = ch2;
        }
        return greater;
    }

    static string GetGreater(string str1, string str2)
    {
        string greater;

        if (str1.CompareTo(str2) >= 0)
        {
            greater = str1;
        }
        else
        {
            greater = str2;
        }
        return greater;
    }
}