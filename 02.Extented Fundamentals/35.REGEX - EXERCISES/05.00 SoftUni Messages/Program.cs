using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
public class Program
{
    public static void Main()  // 100/100
    {
        int searchedLenght = 0;
        
        while (true)
        {
            string encryptedMessage = Console.ReadLine();
            if (encryptedMessage == "Decrypt!")
            {
                break;
            }
            searchedLenght = int.Parse(Console.ReadLine());
            Regex regex = new Regex($@"^\d+([a-zA-Z]{{{searchedLenght}}})[^a-zA-Z\s]*(\d+)$");
            
            Match message = regex.Match(encryptedMessage);
            if (message.Success)
            {
                char[] symbols = encryptedMessage.ToCharArray();
                List<char> letters = new List<char>();
                List<int> digits = new List<int>();
                StringBuilder decrypted = new StringBuilder();

                foreach (char t in symbols)
                {
                    if (Char.IsDigit(t))
                    {
                        digits.Add(t - '0');
                    }
                    if (Char.IsLetter(t))
                    {
                        letters.Add(t);
                    }
                }

                if (searchedLenght >= letters.Count)
                {
                    foreach (int index in digits)
                    {
                        if (index < letters.Count)
                        {
                            char currentLetter = letters[index];
                            decrypted.Append(currentLetter);
                        }
                    }
                    Console.WriteLine($"{string.Join("", letters)} = {decrypted}");
                }
            }
        }
    }
}