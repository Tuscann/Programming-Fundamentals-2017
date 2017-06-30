using System;
class Program
{
    static void Main()
    {
        string type = Console.ReadLine();

        switch (type)
        {
            case "byte": Console.WriteLine("{0}\n{1}", byte.MaxValue, byte.MinValue); break;
            case "sbyte": Console.WriteLine("{0}\n{1}", sbyte.MaxValue, sbyte.MinValue); break;
            case "int": Console.WriteLine("{0}\n{1}", int.MaxValue, int.MinValue); break;
            case "uint": Console.WriteLine("{0}\n{1}", uint.MaxValue, uint.MinValue); break;
            case "long": Console.WriteLine("{0}\n{1}", long.MaxValue, long.MinValue); break;
        }
    }
}