using System;
using System.Linq;
class Program
{
    static void Main()
    {
        string[] phoneNumbers = Console.ReadLine().Split(' ').ToArray();
        string[] names = Console.ReadLine().Split(' ').ToArray();

        while (true)
        {
            string[] comand = Console.ReadLine().Split(' ').ToArray();
            
            if (comand[0] == "done")
            {
                break;
            }
            if (comand[0] == "message")
            {
                int massageNumber;
                bool name = int.TryParse(comand[1], out massageNumber);

                if (massageNumber == 0)
                {
                    int difference = 0;
                    string messageName = comand[1];
                    int nameIndex = Array.IndexOf(names, messageName);
                    Console.WriteLine("sending sms to {0}...",phoneNumbers[nameIndex]);

                    if (int.Parse(phoneNumbers[nameIndex]) == 0)
                    {

                    }


                }
                else
                {
                    Console.WriteLine("sending sms to {0}...", massageNumber);
                }


            }
            else if (comand[0] == "call")
            {


            }

            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == comand[0])
                {
                    Console.WriteLine("{0} -> {1}", names[i], phoneNumbers[i]);
                    break;
                }
            }
        }
    }
}
