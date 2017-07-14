using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        List<double> input = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

        double naturalsSum = 0;
        double sharpSum = 0;

        var notes = new LinkedList<string>();
        var naturals = new LinkedList<string>();
        var sharp = new LinkedList<string>();

        foreach (double note in input)
        {
            switch (note)
            {
                case 261.63:
                    notes.AddLast("C");
                    naturals.AddLast("C");
                    naturalsSum += note;
                    break;
                case 277.18:
                    notes.AddLast("C#");
                    sharp.AddLast("C#");
                    sharpSum += note;
                    break;
                case 293.66:
                    notes.AddLast("D");
                    naturals.AddLast("D");
                    naturalsSum += note;
                    break;
                case 311.13:
                    notes.AddLast("D#");
                    sharp.AddLast("D#");
                    sharpSum += note;
                    break;
                case 329.63:
                    notes.AddLast("E");
                    naturals.AddLast("E");
                    naturalsSum += note;
                    break;
                case 349.23:
                    notes.AddLast("F");
                    naturals.AddLast("F");
                    naturalsSum += note;
                    break;
                case 369.99:
                    notes.AddLast("F#");
                    sharp.AddLast("F#");
                    sharpSum += note;
                    break;
                case 392.00:
                    notes.AddLast("G");
                    naturals.AddLast("G");
                    naturalsSum += note;
                    break;
                case 415.30:
                    notes.AddLast("G#");
                    sharp.AddLast("G#");
                    sharpSum += note;
                    break;
                case 440.00:
                    notes.AddLast("A");
                    naturals.AddLast("A");
                    naturalsSum += note;
                    break;
                case 466.16:
                    notes.AddLast("A#");
                    sharp.AddLast("A#");
                    sharpSum += note;
                    break;
                case 493.88:
                    notes.AddLast("B");
                    naturals.AddLast("B");
                    naturalsSum += note;
                    break;
            }
        }
        Console.WriteLine("Notes: {0}", string.Join(" ", notes));
        Console.WriteLine("Naturals: {0}", string.Join(", ", naturals));
        Console.WriteLine("Sharps: {0}", string.Join(", ", sharp));
        Console.WriteLine("Naturals sum: {0}", naturalsSum);
        Console.WriteLine("Sharps sum: {0}", sharpSum);
    }
}
