using System;
using System.Linq;
class Program
{
    static void Main() // 100/100
    {
        long[] input = Console.ReadLine().Split().Select(long.Parse).ToArray();

        //temp variable - to be used in the swap
        long temp = 0;

        string checker = Console.ReadLine();
        bool chck = checker.Contains("end");

        //While checker !contains "end"
        while (chck != true)
        {

            chck = checker.Contains("end");
            bool multiply = checker.Contains("multiply");
            bool swap = checker.Contains("swap");
            bool decrease = checker.Contains("decrease");

            if (swap)
            {
                string[] positions = checker.Split();
                int pos1 = int.Parse(positions[1]);
                int pos2 = int.Parse(positions[2]);

                temp = input[pos1];
                input[pos1] = input[pos2];
                input[pos2] = temp;
            }
            else if (multiply)
            {
                string[] positions = checker.Split();
                int pos1 = int.Parse(positions[1]);
                int pos2 = int.Parse(positions[2]);

                input[pos1] *= input[pos2];
            }
            else if (decrease)
            {
                input = Array.ConvertAll(input, x => x - 1);
            }
            else if (chck)
            {
                chck = true;
                break;
            }
            checker = Console.ReadLine();
        }
        Console.WriteLine(string.Join(", ", input));
    }
}