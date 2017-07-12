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
            string currentName = Console.ReadLine();
            if (currentName == "done")
            {
                break;
            }
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == currentName)
                {
                    Console.WriteLine("{0} -> {1}", names[i], phoneNumbers[i]);
                    break;
                }
            }
        }
    }
}
