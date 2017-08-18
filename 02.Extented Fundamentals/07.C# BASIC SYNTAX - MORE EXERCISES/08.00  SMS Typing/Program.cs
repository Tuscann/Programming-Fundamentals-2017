using System;

public class SMS_Typing
{
    public static void Main() // 100/100
    {
        int n = int.Parse(Console.ReadLine());

        string sms = string.Empty;

        sms = GetSMS(n, sms);

        Console.WriteLine(sms);
    }

    private static string GetSMS(int n, string SMS)
    {
        for (int i = 0; i < n; i++)
        {
            string currentMessageCharacters = Console.ReadLine();

            if (currentMessageCharacters == "0")
            {
                SMS += " ";
            }
            else
            {
                int mainDigit = int.Parse(currentMessageCharacters[0].ToString());
                int numberOfDigits = currentMessageCharacters.Length;

                int offset = (mainDigit - 2) * 3;

                if (mainDigit == 8 || mainDigit == 9)
                {
                    offset++;
                }

                int letterIndex = offset + numberOfDigits - 1;

                char currentMessage = (char)(letterIndex + 97);

                SMS += currentMessage;
            }
        }
        return SMS;
    }
}