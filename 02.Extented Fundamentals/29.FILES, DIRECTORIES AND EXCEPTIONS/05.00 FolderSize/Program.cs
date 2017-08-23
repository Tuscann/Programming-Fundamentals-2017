using System.IO;
public class Program
{
    public static void Main()
    {
        string[] files = Directory.GetFiles("TestFolder");

        double sumSizes = 0;

        foreach (string file in files)
        {
            FileInfo fileInfo = new FileInfo(file);
            sumSizes += fileInfo.Length;
        }

        sumSizes = sumSizes / 1024 / 1024;

        File.WriteAllText("FolderSize.txt", sumSizes.ToString());
    }
}