using System;
using System.Collections.Generic;
class RecordUniqueNames
{
    static void Main()
    {
        HashSet<string> names = new HashSet<string>();
        int inputCnt = int.Parse(Console.ReadLine());

        for (int cnt = 0; cnt < inputCnt; cnt++)
        {
            string currentName = Console.ReadLine();
            names.Add(currentName);
        }
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
    }
}