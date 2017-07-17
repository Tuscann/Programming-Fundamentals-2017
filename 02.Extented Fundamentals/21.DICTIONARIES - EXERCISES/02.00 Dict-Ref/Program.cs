using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        Dictionary<string, int> dic = new Dictionary<string, int>();

        while (true)
        {
            List<string> curentRow = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            if (curentRow[0] == "end")
            {
                break;
            }
            string name = curentRow[0];
            string secondName = curentRow[2];
            int value = 0;

            if (int.TryParse(curentRow[2], out value)) // is number
            {
                dic[name] = value;
            }
            else
            {
                if (dic.ContainsKey(secondName))
                {
                    dic[name] = dic[secondName];
                }
            }
        }
        foreach (KeyValuePair<string, int> row in dic)
        {
            Console.WriteLine("{0} === {1}", row.Key, row.Value);
        }
    }
}