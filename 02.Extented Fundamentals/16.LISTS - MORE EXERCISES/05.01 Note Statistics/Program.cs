using System;
using System.Collections.Generic;
using System.Linq;
public class NoteStatistics
{
    public static void Main() // 100/100
    {
        List<double> realNumbersInput = Console.ReadLine().Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries).Select(double.Parse)
            .ToList();

        NoteAndSumOfTheFrequency(realNumbersInput);
    }

    static void NoteAndSumOfTheFrequency(List<double> realNumbersInput)
    {
        List<string> noteList = new List<string> { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };
        List<double> frequencyList = new List<double> { 261.63, 277.18, 293.66, 311.13, 329.63, 349.23, 369.99, 392.00, 415.30, 440.00, 466.16, 493.88 };

        List<string> notes = new List<string>();
        List<string> naturalNotes = new List<string>();
        List<string> sharpsNotes = new List<string>();

        int len = frequencyList.Count;
        
        foreach (double number in realNumbersInput)
        {
            for (int i = 0; i < len; i++)
            {
                double currentNumber = frequencyList[i];

                if (currentNumber == number)
                {
                    notes.Add(noteList[i]);
                    break;
                }
            }
        }
        for (int i = 0; i < notes.Count; i++)
        {
            string currentNote = notes[i].ToString();

            if (currentNote.Length < 2)
            {
                naturalNotes.Add(notes[i]);
            }
            else
            {
                sharpsNotes.Add(notes[i]);
            }
        }
        double naturalSum = SumOfNotes(noteList, frequencyList, naturalNotes);
        double sharpsSum = SumOfNotes(noteList, frequencyList, sharpsNotes);

        Console.WriteLine($"Notes: {string.Join(" ", notes)}");
        Console.WriteLine($"Naturals: {string.Join(", ", naturalNotes)}");
        Console.WriteLine($"Sharps: {string.Join(", ", sharpsNotes)}");
        Console.WriteLine($"Naturals sum: {naturalSum}");
        Console.WriteLine($"Sharps sum: {sharpsSum}");
    }

    static double SumOfNotes(List<string> noteList, List<double> frequencyList, List<string> notes)
    {
        double sum = 0;
        foreach (string note in notes)
        {

            for (int i = 0; i < noteList.Count; i++)
            {

                string currentNote = noteList[i];

                if (note == currentNote)
                {
                    sum += frequencyList[i];
                }
            }
        }
        return sum;
    }
}