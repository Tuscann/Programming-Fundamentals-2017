using System;
public class Program
{
    public static void Main() // 100/100
    {
        string lineOne = Console.ReadLine();

        while (lineOne != "collapse")
        {
            string lineTwo = Console.ReadLine();

            while (lineTwo.Length > 0)
            {
                bool contains = lineOne.Contains(lineTwo);

                if (contains)
                {
                    lineOne = lineOne.Replace(lineTwo, string.Empty);
                }
                else
                {
                    lineTwo = lineTwo.Remove(0, 1);
                    if (lineTwo.Length > 0)
                    {
                        lineTwo = lineTwo.Remove((lineTwo.Length - 1), 1);
                    }
                }
            }

            if (lineOne.Length > 0)
            {
                Console.WriteLine(lineOne.Trim());
            }
            else
            {
                Console.WriteLine("(void)");
            }
            lineOne = Console.ReadLine();
        }
    }
}