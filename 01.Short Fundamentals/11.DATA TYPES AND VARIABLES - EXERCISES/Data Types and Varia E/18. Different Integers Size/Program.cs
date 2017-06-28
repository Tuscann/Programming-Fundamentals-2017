using System;
using System.Collections.Generic;
using System.Numerics;
class Program
{
    static void Main()
    {
        string x = Console.ReadLine();

        try
        {
            long n = long.Parse(x);

            List<string> storeNumber = new List<string>();
            string sbytes = "sbyte";
            string bytes = "byte";
            string shorts = "short";
            string ushorts = "ushort";
            string ints = "int";
            string uints = "uint";
            string longs = "long";

            if (n >= sbyte.MinValue && n <= sbyte.MaxValue)
            {
                storeNumber.Add(sbytes);
            }
            if (n >= byte.MinValue && n <= byte.MaxValue)
            {
                storeNumber.Add(bytes);
            }
            if (n >= short.MinValue && n <= short.MaxValue)
            {
                storeNumber.Add(shorts);
            }
            if (n >= ushort.MinValue && n <= ushort.MaxValue)
            {
                storeNumber.Add(ushorts);
            }
            if (n >= int.MinValue && n <= int.MaxValue)
            {
                storeNumber.Add(ints);
            }
            if (n >= uint.MinValue && n <= uint.MaxValue)
            {
                storeNumber.Add(uints);
            }
            if (n >= long.MinValue && n <= long.MaxValue)
            {
                storeNumber.Add(longs);
            }

            Console.WriteLine("{0} can fit in:", x);
            for (int i = 0; i < storeNumber.Count; i++)
            {
                Console.WriteLine("* {0}", storeNumber[i]);
            }
        }
        catch
        {
            Console.WriteLine("{0} can't fit in any type", x);
        }
    }
}