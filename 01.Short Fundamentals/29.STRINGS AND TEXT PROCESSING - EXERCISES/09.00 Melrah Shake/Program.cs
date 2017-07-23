using System;
class Program
{
    static void Main()  // 100/100
    {
        string stringInput = Console.ReadLine();
        string pattern = Console.ReadLine();

        while (stringInput.Length > 0 && pattern.Length > 0)
        {
            int firstIndex = stringInput.IndexOf(pattern);
            int lastIndex = stringInput.LastIndexOf(pattern);

            if (firstIndex >= 0 && lastIndex >= 0 && firstIndex != lastIndex)
            {
                Console.WriteLine("Shaked it.");

                stringInput = stringInput.Remove(firstIndex, pattern.Length);
                lastIndex = stringInput.LastIndexOf(pattern);
                stringInput = stringInput.Remove(lastIndex, pattern.Length);

                pattern = pattern.Remove(pattern.Length / 2, 1);
            }
            else
            {
                break;
            }
        }
        Console.WriteLine("No shake.");
        Console.WriteLine(stringInput);
    }
}