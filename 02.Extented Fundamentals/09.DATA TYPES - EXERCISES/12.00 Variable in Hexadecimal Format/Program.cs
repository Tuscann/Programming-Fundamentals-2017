using System;
class FromHexToDecValue
{
    static void Main() // 100/100
    {
        string numberInHex = Console.ReadLine();
        int numberInDecimal = Convert.ToInt32(numberInHex, 16);
        Console.WriteLine(numberInDecimal);
    }
}