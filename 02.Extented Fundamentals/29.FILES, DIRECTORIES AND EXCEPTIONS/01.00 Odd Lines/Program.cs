using System.Linq;
using System.IO;
public class Program
{
    public static void Main()
    {
        string[] text = File.ReadAllLines("input.txt");

        string[] oddLines = text
            .Where((t, index) => index % 2 == 1)
            .ToArray();

        File.WriteAllLines("oddLines.txt", oddLines);
    }
}