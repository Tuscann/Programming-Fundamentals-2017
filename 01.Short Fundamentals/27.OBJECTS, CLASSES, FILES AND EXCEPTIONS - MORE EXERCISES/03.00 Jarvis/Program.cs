using System;
using System.Collections.Generic;
using System.Linq;

public class SoftUniDemosC
{
    public static void Main() // 100/100
    {
        Jarvis jarvis = new Jarvis();

        long energy = long.Parse(Console.ReadLine());

        string[] command = Console.ReadLine().Split();

        while (command[0] != "Assemble!")
        {
            jarvis.Apply(PartFactory.Get(command));
            command = Console.ReadLine().Split();
        }

        switch (jarvis.Assemble(energy))
        {
            case 1:
                Console.WriteLine("We need more parts!");
                break;
            case 2:
                Console.WriteLine("We need more power!");
                break;
            default:
                Console.WriteLine(jarvis);
                break;
        }
    }
}

internal class Jarvis
{
    private long energy = 0;
    private Head head;
    private Torso torso;
    private readonly List<Arm> arms = new List<Arm>();
    private readonly List<Leg> legs = new List<Leg>();

    public bool Apply(Part p)
    {
        if (p == null) return false;

        switch (p.GetType().Name)
        {
            case "Head":
                Head h = (Head)p;
                if (head != null)
                {
                    if (h.Energy >= head.Energy) return false;
                    energy -= head.Energy - h.Energy;
                    head = h;
                }
                else
                {
                    head = h;
                    energy += h.Energy;
                }
                return true;
            case "Torso":
                Torso t = (Torso)p;
                if (torso != null)
                {
                    if (t.Energy >= torso.Energy) return false;
                    energy -= torso.Energy - t.Energy;
                    torso = t;
                }
                else
                {
                    torso = t;
                    energy += t.Energy;
                }
                return true;
            case "Arm":
                Arm a = (Arm)p;
                if (arms.Count > 1)
                {
                    int idx = arms[0].Energy > arms[1].Energy ? 0 : 1;
                    if (a.Energy >= arms[idx].Energy) return false;
                    energy -= arms[idx].Energy - a.Energy;
                    arms.RemoveAt(idx);
                    arms.Add(a);
                }
                else
                {
                    arms.Add(a);
                    energy += a.Energy;
                }
                return true;
            case "Leg":
                Leg l = (Leg)p;
                if (legs.Count > 1)
                {
                    int idx = legs[0].Energy > legs[1].Energy ? 0 : 1;
                    if (l.Energy >= legs[idx].Energy) return false;
                    energy -= legs[idx].Energy - l.Energy;
                    legs.RemoveAt(idx);
                    legs.Add(l);
                }
                else
                {
                    legs.Add(l);
                    energy += l.Energy;
                }
                return true;
            default:
                return false;
        }
    }

    public int Assemble(long energy)
    {
        if (head == null || torso == null || legs.Count != 2 || arms.Count != 2)
        {
            return 1;
        }
        if (energy < this.energy)
        {
            return 2;
        }
        return 0;
    }

    public override string ToString()
    {
        return $"{GetType().Name}:\n{head}\n{torso}\n{string.Join("\n", arms.OrderBy(a => a.Energy))}\n{string.Join("\n", legs.OrderBy(l => l.Energy))}";
    }
}

internal abstract class Part { }

internal class Head : Part
{
    public int Energy { get; }
    public int Iq { get; }
    public string Material { get; }

    public Head() { }

    public Head(int e, int i, string m)
    {
        Energy = e;
        Iq = i;
        Material = m;
    }

    public override string ToString()
    {
        return $"#{GetType().Name}:\n###Energy consumption: {Energy}\n###IQ: {Iq}\n###Skin material: {Material}";
    }
}

internal class Torso : Part
{
    public int Energy { get; }
    public double Size { get; }
    public string Material { get; }

    public Torso() { }

    public Torso(int e, double d, string m)
    {
        Energy = e;
        Size = d;
        Material = m;
    }

    public override string ToString()
    {
        return $"#{GetType().Name}:\n###Energy consumption: {Energy}\n###Processor size: {Size:0.0}\n###Corpus material: {Material}";
    }
}

internal class Arm : Part
{
    public int Energy { get; }
    public int Reach { get; }
    public int Fingers { get; }

    public Arm() { }

    public Arm(int e, int r, int f)
    {
        Energy = e;
        Reach = r;
        Fingers = f;
    }

    public override string ToString()
    {
        return $"#{GetType().Name}:\n###Energy consumption: {Energy}\n###Reach: {Reach}\n###Fingers: {Fingers}";
    }
}

internal class Leg : Part
{
    public int Energy { get; }
    public int Strength { get; }
    public int Speed { get; }

    public Leg() { }

    public Leg(int e, int s, int sp)
    {
        Energy = e;
        Strength = s;
        Speed = sp;
    }

    public override string ToString()
    {
        return $"#{GetType().Name}:\n###Energy consumption: {Energy}\n###Strength: {Strength}\n###Speed: {Speed}";
    }
}

internal static class PartFactory
{
    public static Part Get(string[] input)
    {
        if (input.Length != 4) return null;
        try
        {

            switch (input[0])
            {
                case "Head":
                    return new Head(int.Parse(input[1]), int.Parse(input[2]), input[3]);
                case "Torso":
                    return new Torso(int.Parse(input[1]), double.Parse(input[2]), input[3]);
                case "Arm":
                    return new Arm(int.Parse(input[1]), int.Parse(input[2]), int.Parse(input[3]));
                case "Leg":
                    return new Leg(int.Parse(input[1]), int.Parse(input[2]), int.Parse(input[3]));
                default:
                    return null;
            }
        }
        catch
        {
            return null;
        }
    }
}