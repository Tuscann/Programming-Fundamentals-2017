using System;
using System.Collections.Generic;
class Append_Lists
{
    static void Main()
    {
        List<string[]> sequences = new List<string[]>();
        string[] seqs = Console.ReadLine().Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

        for (int i = seqs.Length - 1; i >= 0; i--)
        {
            string[] sequence = seqs[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            sequences.Add(sequence);
        }
        foreach (var sequence in sequences)
        {
            Console.Write("{0} ", string.Join(" ", sequence));
        }
    }
}
