using System.IO;
public class Program
{
    public static void Main()
    {
        string[] textLines = File.ReadAllLines("Input.txt");

        for (int i = 1; i <= textLines.Length; i++)
        {
            textLines[i - 1] = i + ". " + textLines[i - 1];
        }

        File.WriteAllLines("LineNumbers.txt", textLines);
    }
}