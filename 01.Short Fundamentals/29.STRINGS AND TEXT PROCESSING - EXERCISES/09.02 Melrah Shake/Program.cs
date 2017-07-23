using System;
public class MelrahShake
{
    public static void Main()  // 100/100
    {
        string text = Console.ReadLine();
        string pattern = Console.ReadLine();

        while (text.Length > 0 && pattern.Length > 0)
        {
            int firstIndex = text.IndexOf(pattern);
            int lastIndex = text.LastIndexOf(pattern);

            if (firstIndex >= 0 && lastIndex >= 0 && firstIndex != lastIndex)
            {
                Console.WriteLine("Shaked it.");
                text = text.Remove(firstIndex, pattern.Length);
                lastIndex = text.LastIndexOf(pattern);
                text = text.Remove(lastIndex, pattern.Length);
                pattern = pattern.Remove(pattern.Length / 2, 1);
            }
            else
            {
                Console.WriteLine("No shake.");
                Console.WriteLine(text);
                break;
            }
        }

        if (pattern.Length < 1 || text.Length < 1)
        {
            Console.WriteLine("No shake.");
            Console.WriteLine(text);
        }
    }
}