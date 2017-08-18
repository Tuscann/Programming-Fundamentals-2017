using System;
class P08_SmsTyping
{
    static void Main() // 100/100
    {
        string[][] smsTable = 
        {
                new []{" "},
                new string[]{ },
                new []{"a", "b","c"},
                new string[]{"d","e","f"},
                new string[]{"g","h","i"},
                new string[]{"j","k","l" },
                new string[]{"m","n","o"},
                new string[]{"p","q","r","s"},
                new string[]{"t","u","v" },
                new string[]{"w","x","y","z" }
        };

        int characterCount = int.Parse(Console.ReadLine());
        string outputSms = "";
        for (int i = 0; i < characterCount; i++)
        {
            int charCode = int.Parse(Console.ReadLine());
            outputSms += smsTable[charCode % 10][charCode.ToString().Length - 1];
        }
        Console.WriteLine(outputSms);
    }
}