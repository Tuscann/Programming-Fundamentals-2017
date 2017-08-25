using System;
using System.Collections.Generic;
using System.Linq;
class NoteStatistics
{
    static void Main() // 100/100
    {
        List<decimal> input = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();

        Dictionary<decimal, string> notes = new Dictionary<decimal, string>()
        {
            {261.63M,"C"},
            {277.18M,"C#"},
            {293.66M,"D"},
            {311.13M,"D#"},
            {329.63M,"E"},
            {349.23M,"F"},
            {369.99M,"F#"},
            {392M,"G"},
            {415.3M,"G#"},
            {440M,"A"},
            {466.16M,"A#"},
            {493.88M,"B"},
        };

        string[] note = new string[input.Count];
        List<string> naturals = new List<string>();
        List<string> sharps = new List<string>();
        decimal sumNaturals = new decimal();
        decimal sumSharps = new decimal();
        int counter = 0;

        foreach (var item in input)
        {
            if (notes.ContainsKey(input[counter]))
            {
                note[counter] = notes[item];
                if (note[counter].Length == 1)
                {
                    naturals.Add(note[counter]);
                    sumNaturals += input[counter];
                }
                else
                {
                    sharps.Add(note[counter]);
                    sumSharps += input[counter];
                }
            }
            counter++;
        }
        Console.WriteLine("Notes: {0}", string.Join(" ", note));
        Console.WriteLine($"Naturals: {string.Join(", ", naturals)}");
        Console.WriteLine($"Sharps: {string.Join(", ", sharps)}");
        Console.WriteLine($"Naturals sum: {sumNaturals}");
        Console.WriteLine($"Sharps sum: {sumSharps}");
    }
}