using System;
class StringEncyption
{
    static void Main() // 100/100
    {
        int n = int.Parse(Console.ReadLine());
        GetTheEncryptedString(n);
    }

    static void GetTheEncryptedString(int n)
    {
        string encryptedString = String.Empty;
        for (int i = 0; i < n; i++)
        {
            char letter = char.Parse(Console.ReadLine());
            encryptedString += Encrypt(letter);
        }
        Console.WriteLine(encryptedString);
    }

    static string Encrypt(char letter)
    {
        string result = String.Empty;
        //Here, we convert char respresentation of letter to int representation
        int letterASCIIToNumber = (int)letter;
        //Then, we convert the number we've found to string
        string letterASCII = ((int)letter).ToString();

        //Now could find the digits of ASCII code of the leter 
        //and therefore we can operate with the ASCII code of letter
        // -> example: Now we can find the first and the last digit of letter ASCII Code
        int letterASCIILength = letterASCII.Length;
        string firstDigitOfLetterASCII = letterASCII[0].ToString();
        string lastDigitOfLetterASCII = letterASCII[letterASCIILength - 1].ToString();

        //Here, we convert the first and last digit of ASCII code from string to int,
        //because we want to perform some arithmetic operations with the ASCII code 
        int firstDigitToInt = int.Parse(firstDigitOfLetterASCII);
        int lastDigitToInt = int.Parse(lastDigitOfLetterASCII);

        //Here: 
        //we have a new ASCII code, received by the arithmetic operations we've performed.
        //The new ASCII code is converted to a charecter
        char charAfterLastDigit = (char)(letterASCIIToNumber + lastDigitToInt);
        char charBeforeFirstDigit = (char)(letterASCIIToNumber - firstDigitToInt);

        //We form a result (for each letter seperately), as described 
        result = charAfterLastDigit + firstDigitOfLetterASCII + lastDigitOfLetterASCII + charBeforeFirstDigit;
        return result;
    }
}