using System;
using System.Linq;
class Z1
{
    static void Main() // 100/100
    {
        double[] array = Console.ReadLine().Split().Select(double.Parse).ToArray();

        double average = array.Average();

        double[] asa = array.Where(a => a > average).OrderByDescending(x => x).ToArray();

        var same = asa.ToList();
        bool result = same.All(item => item == 1);

        if (result) { Console.WriteLine("No"); }
        if (asa.Length >= 5)
        {
            double[] x = asa.Take(5).ToArray();

            Console.WriteLine(string.Join(" ", x));
        }
        else
        {
            Console.WriteLine(string.Join(" ", asa));
        }
    }
}