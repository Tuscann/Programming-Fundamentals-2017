using System;
public class Program
{ 
    public static void Main()  // 100/100
    { 
        string inputLine = Console.ReadLine();

        while (inputLine != "end")
        {
            string[] elements = inputLine.Trim()
                .Split(new[] { ' ', '.', ',', ':', ';', '?', '!', '-', '_' },
                    StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < elements.Length; i++)
            {
                string word = elements[i].ToLower();
                string firstLetter = word[0].ToString().ToUpper();

                elements[i] = firstLetter + word.Substring(1);
            }
            Console.WriteLine(string.Join(", ", elements));

            inputLine = Console.ReadLine();
        }
    }
}