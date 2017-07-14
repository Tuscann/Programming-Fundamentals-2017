using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        List<string> noteStatistics = new List<string>
            { "C", "261.63","C#" , "277.18","D", "293.66",
                "D#", "311.13", "E", "329.63", "F", "349.23",
                "F#", "369.99", "G", "392.0", "G#", "415.3",
                "A", "440.0", "A#", "466.16", "B", "493.88" };

        List<string> altogetherNotes = new List<string>();
        List<string> onlyNaturals = new List<string>();
        List<string> onlySharps = new List<string>();
        List<decimal> sumNaturals = new List<decimal>();
        List<decimal> sumSharps = new List<decimal>();

        List<string> inputFreqs = Console.ReadLine().Split(' ').ToList();
        for (int cycleInputFreqs = 0; cycleInputFreqs < inputFreqs.Count; cycleInputFreqs++)
        {
            for (int cycleNoteStatistics = 0; cycleNoteStatistics < noteStatistics.Count; cycleNoteStatistics++)
            {
                if (inputFreqs[cycleInputFreqs] == noteStatistics[cycleNoteStatistics] && noteStatistics[cycleNoteStatistics - 1].Contains("#"))
                {
                    altogetherNotes.Add(noteStatistics[cycleNoteStatistics - 1]);
                    onlySharps.Add(noteStatistics[cycleNoteStatistics - 1]);
                    sumSharps.Add(decimal.Parse(noteStatistics[cycleNoteStatistics]));
                }
                else if (inputFreqs[cycleInputFreqs] == noteStatistics[cycleNoteStatistics])
                {
                    altogetherNotes.Add(noteStatistics[cycleNoteStatistics - 1]);
                    onlyNaturals.Add(noteStatistics[cycleNoteStatistics - 1]);
                    sumNaturals.Add(decimal.Parse(noteStatistics[cycleNoteStatistics]));
                }
            }
        }
        Console.WriteLine("Notes: " + string.Join(" ", altogetherNotes));
        Console.WriteLine("Naturals: " + string.Join(", ", onlyNaturals));
        Console.WriteLine("Sharps: " + string.Join(", ", onlySharps));
        Console.WriteLine("Naturals sum: {0:f2}", sumNaturals.Sum());
        Console.WriteLine("Sharps sum: {0:f2}", sumSharps.Sum());
    }
}
