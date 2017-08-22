using System;
using System.Collections.Generic;
using System.Linq;

public class Wagon
{
    private string wagonName;
    private int wagonPower;

    public Wagon(string wagonName, int wagonPower)
    {
        this.wagonName = wagonName;
        this.wagonPower = wagonPower;
    }

    public string WagonName
    {
        get { return wagonName; }
        set { this.wagonName = value; }
    }

    public int WagonPower
    {
        get { return wagonPower; }
        set { this.wagonPower = value; }
    }
}

public class Train
{
    private string trainName;
    private List<Wagon> composition = new List<Wagon>();
    private long sumWagonsPower;

    public long SumWagonsPower
    {
        get { return composition.Sum(x => x.WagonPower); }
    }

    public Train(string trainName)
    {
        this.trainName = trainName;
    }

    public string TrainName
    {
        get { return trainName; }
        set { this.trainName = value; }
    }

    public List<Wagon> Composition
    {
        get { return composition; }
        set { this.composition = value; }
    }
}

public class Trainegram
{
    static string currentTrainName;
    static string currentWagonName;
    static int currentWagonPower;

    static string first;
    static string other;

    static List<Train> trainCollection = new List<Train>();

    public static void Main() // 100/100
    {
        ReadNextLinesFrom(Console.ReadLine());

        trainCollection = trainCollection
            .OrderByDescending(x => x.SumWagonsPower)
            .ThenBy(x => x.Composition.Count).ToList();

        foreach (var train in trainCollection)
        {
            Console.WriteLine($"Train: {train.TrainName}");
            foreach (var wagon in train.Composition.OrderByDescending(x => x.WagonPower))
            {
                Console.WriteLine($"###{wagon.WagonName} - {wagon.WagonPower}");
            }
        }
    }

    public static void ReadNextLinesFrom(string input)
    {
        if (input != "It's Training Men!")
        {
            DivideAndRule(input);
            ReadNextLinesFrom(Console.ReadLine());
        }
    }

    public static void DivideAndRule(string input)
    {
        var pattern = new[] { "->", ":", "=", " " };
        var splited = input.Split(pattern, StringSplitOptions.RemoveEmptyEntries);

        if (splited.Length == 3)
        {
            currentTrainName = splited[0];
            currentWagonName = splited[1];
            currentWagonPower = Convert.ToInt32(splited[2]);

            AddNewTrain();
        }
        else DoSomthing(input, splited);
    }

    public static void AddNewTrain()
    {
        if (!trainCollection.Any(x => x.TrainName == currentTrainName))
        {
            var newWagon = new Wagon(currentWagonName, currentWagonPower);
            var newTrain = new Train(currentTrainName);
            newTrain.Composition.Add(newWagon);

            trainCollection.Add(newTrain);
        }
        else
        {
            var currentTrain = trainCollection.Where(x => x.TrainName == currentTrainName).First();
            var newWagonToAdd = new Wagon(currentWagonName, currentWagonPower);
            currentTrain.Composition.Add(newWagonToAdd);
        }
    }

    public static void DoSomthing(string input, string[] splited)
    {
        first = splited[0];
        other = splited[1];

        if (input.Contains("="))
        {
            CopyFirstToOther();
        }
        else AddAndRemove();
    }

    private static void CopyFirstToOther()
    {
        if (!trainCollection.Any(x => x.TrainName == first))
        {
            var newTrain = new Train(first);
            newTrain.Composition = new List<Wagon>();

            var otherTrain = trainCollection.Where(x => x.TrainName == other).First();
            
            foreach (Wagon item in otherTrain.Composition)
            {
                newTrain.Composition.Add(item);
            }
            trainCollection.Add(newTrain);
        }
        else
        {
            var firstTrain = trainCollection.Where(x => x.TrainName == first).First();
            var otherTrain = trainCollection.Where(x => x.TrainName == other).First();
            firstTrain.Composition.Clear();
            
            foreach (Wagon item in otherTrain.Composition)
            {
                firstTrain.Composition.Add(item);
            }
        }
    }

    private static void AddAndRemove()
    {
        if (!trainCollection.Any(x => x.TrainName == first))
        {
            var otherTrain = trainCollection.Where(x => x.TrainName == other).FirstOrDefault();
            var newTrain = new Train(first);
            
            foreach (Wagon item in otherTrain.Composition)
            {
                newTrain.Composition.Add(item);
            }

            trainCollection.Remove(otherTrain);
            trainCollection.Add(newTrain);
        }
        else
        {
            var firstTrain = trainCollection.Where(x => x.TrainName == first).FirstOrDefault();
            var otherTrain = trainCollection.Where(x => x.TrainName == other).FirstOrDefault();
            
            foreach (Wagon item in otherTrain.Composition)
            {
                firstTrain.Composition.Add(item);
            }

            trainCollection.Remove(otherTrain);
        }
    }
}