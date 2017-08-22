using System;
using System.Linq;
using System.Collections.Generic;

public class SpyGram
{
    static byte[] keyToByteArray;

    public static void Main() // 100/100
    {
        Dictionary<string, List<string>> allEncryptedMessages = new Dictionary<string, List<string>>();
        string privateKey = Console.ReadLine();
        int indexDivider = privateKey.Length;
        keyToByteArray = ParseToByteArray(privateKey);

        string encryptedMessage = string.Empty;
        for (int infiniatly = 0; ; infiniatly++)
        {
            string inputMessage = Console.ReadLine();
            if (inputMessage == "END") { break; }

            string[] currentSplitedMessage = inputMessage.Split(new string[] { ": ", "; " }, StringSplitOptions.RemoveEmptyEntries);

            string person = currentSplitedMessage[1];
            string toUpper = currentSplitedMessage[1].ToUpper();
            string to = currentSplitedMessage[0];
            string message = currentSplitedMessage[2];

            if (to == "TO" && message == "MESSAGE" && person == toUpper)
            {
                if (!allEncryptedMessages.ContainsKey(person))
                {
                    allEncryptedMessages[person] = new List<string>();
                }
                encryptedMessage = ProcessEncrypting(inputMessage, indexDivider);
                allEncryptedMessages[person].Add(encryptedMessage);
            }
        }
        PrintSortedEncryptedMessagesFrom(allEncryptedMessages);
    }

    static byte[] ParseToByteArray(string privateKey)
    {
        byte[] temporaryByteArray = new byte[privateKey.Length];
        for (int index = 0; index < privateKey.Length; index++)
        {
            byte currentSymbolAsNumber = Convert.ToByte(privateKey[index].ToString());
            temporaryByteArray[index] = currentSymbolAsNumber;
        }
        return temporaryByteArray;
    }

    static string ProcessEncrypting(string inputMessage, int divider)
    {
        string encryptedMessage = string.Empty;
        for (int index = 0; index < inputMessage.Length; index++)
        {
            int keyIndex = index == 0 ? 0 : index % divider;
            byte keyNumber = keyToByteArray[keyIndex];
            int currentSymbol = inputMessage[index] + keyNumber;
            encryptedMessage += (char)currentSymbol;
        }
        return encryptedMessage;
    }

    private static void PrintSortedEncryptedMessagesFrom(
        Dictionary<string, List<string>> allEncryptedMessages)
    {
        foreach (KeyValuePair<string, List<string>> person in allEncryptedMessages.OrderBy(x => x.Key))
        {
            foreach (string message in person.Value)
            {
                Console.WriteLine(message);
            }
        }
    }
}