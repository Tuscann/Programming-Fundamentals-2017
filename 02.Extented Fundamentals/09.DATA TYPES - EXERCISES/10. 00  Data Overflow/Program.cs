using System;
class DataOverflow
{
    static void Main() // 100/100
    {
        ulong firstNumber = ulong.Parse(Console.ReadLine());
        ulong secondNumber = ulong.Parse(Console.ReadLine());

        ulong[] array = { firstNumber, secondNumber };
        string[] types = { String.Empty, String.Empty };

        for (int i = 0; i < 2; i++)
        {
            if (byte.MinValue <= array[i] && byte.MaxValue >= array[i])
            {
                types[i] += "byte";
            }
            else if (ushort.MinValue <= array[i] && ushort.MaxValue >= array[i])
            {
                types[i] += "ushort";
            }
            else if (uint.MinValue <= array[i] && uint.MaxValue >= array[i])
            {
                types[i] += "uint";
            }
            else
            {
                types[i] += "ulong";
            }
        }

        string biggerType = String.Empty, smallerType = String.Empty;
        ulong biggerNumber;

        if (firstNumber >= secondNumber)
        {
            biggerNumber = array[0];
            biggerType = types[0];
            smallerType = types[1];
        }
        else
        {
            biggerNumber = array[1];
            biggerType = types[1];
            smallerType = types[0];
        }

        decimal overflow = 0m;

        if (smallerType == "byte")
        {
            overflow = biggerNumber * 1.0m / byte.MaxValue;
        }
        else if (smallerType == "ushort")
        {
            overflow = biggerNumber * 1.0m / ushort.MaxValue;
        }
        else if (smallerType == "uint")
        {
            overflow = biggerNumber * 1.0m / uint.MaxValue;
        }
        else
        {
            overflow = biggerNumber * 1.0m / ulong.MaxValue;
        }

        Console.WriteLine("bigger type: {0}", biggerType);
        Console.WriteLine("smaller type: {0}", smallerType);
        Console.WriteLine("{0} can overflow {1} {2} times", biggerNumber, smallerType, Math.Round(overflow));
    }
}