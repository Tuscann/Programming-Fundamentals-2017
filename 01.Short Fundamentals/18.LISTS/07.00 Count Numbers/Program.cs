using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        input.Sort((a, b) => a.CompareTo(b));

        IEnumerable<IGrouping<int, int>> groups = input.GroupBy(item => item);
        
        foreach (var group in groups)
        {
            Console.WriteLine("{0} -> {1}", group.Key,group.Count());
        }
    }
}