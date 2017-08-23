using System;
class FloatOrInteger
{
    static void Main() // 100/100
    {
        string str = Console.ReadLine();

        float floatNum;
        bool isFloat = float.TryParse(str, out floatNum);
        int integerNum;
        bool isInteger = int.TryParse(str, out integerNum);

        if (isFloat)
        {
            Console.WriteLine(Math.Round(floatNum));
        }
        else if (isInteger)
        {
            Console.WriteLine(integerNum);
        }
    }
}