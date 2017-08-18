using System;
using System.Collections.Generic;
using System.Linq;

class P03_Jarvis
{
    static void Main() // 100/100
    {
        long maxEnergy = long.Parse(Console.ReadLine());

        Ultron ultron = new Ultron();
        GetPartsForUltron(ultron);
        PrintUltronAsemblyStatus(ultron, maxEnergy);
    }

    static void PrintUltronAsemblyStatus(Ultron ultron, long maxEnergy)
    {
        if (ultron.TotalEnergy > maxEnergy)
        {
            Console.WriteLine("We need more power!");
        }
        else if (ultron.Head == null || ultron.Torso == null ||
                 ultron.Arms.Count != 2 || ultron.Legs.Count != 2)
        {
            Console.WriteLine("We need more parts!");
        }
        else
        {
            Console.WriteLine("Jarvis:"); // fake Ultron
            Console.WriteLine(ultron.Head);
            Console.WriteLine(ultron.Torso);
            foreach (Arm arm in ultron.Arms)
            {
                Console.WriteLine(arm);
            }
            foreach (Leg leg in ultron.Legs)
            {
                Console.WriteLine(leg);
            }
        }

    }

    static void GetPartsForUltron(Ultron ultron)
    {
        string command = Console.ReadLine();
        while (command != "Assemble!")
        {
            string part = command.Split(' ').First();
            string[] partSepcs = command.Split(' ').Skip(1).ToArray();

            switch (part)
            {
                case "Head":
                    GetHead(ultron, partSepcs);
                    break;
                case "Torso":
                    GetTorso(ultron, partSepcs);
                    break;
                case "Arm":
                    GetArm(ultron, partSepcs);
                    break;
                case "Leg":
                    GetLeg(ultron, partSepcs);
                    break;
            }

            command = Console.ReadLine();
        }
    }

    static void GetLeg(Ultron ultron, string[] partSepcs)
    {
        Leg newLeg = new Leg
        {
            EnergyConsumption = int.Parse(partSepcs[0]),
            Strenght = int.Parse(partSepcs[1]),
            Speed = int.Parse(partSepcs[2])
        };

        ultron.Legs.Add(newLeg);
        ultron.Legs = ultron.Legs.OrderBy(ec => ec.EnergyConsumption).ToList();
        if (ultron.Legs.Count > 2)
        {
            ultron.Legs = ultron.Legs.Take(2).ToList();
        }
    }

    static void GetArm(Ultron ultron, string[] partSepcs)
    {
        Arm newArm = new Arm
        {
            EnergyConsumption = int.Parse(partSepcs[0]),
            ReachDistance = int.Parse(partSepcs[1]),
            FingersCount = int.Parse(partSepcs[2])
        };

        ultron.Arms.Add(newArm);
        ultron.Arms = ultron.Arms.OrderBy(ec => ec.EnergyConsumption).ToList();
        if (ultron.Arms.Count > 2)
        {
            ultron.Arms = ultron.Arms.Take(2).ToList();
        }
    }

    static void GetTorso(Ultron ultron, string[] partSepcs)
    {
        Torso newTorso = new Torso
        {
            EnergyConsumption = int.Parse(partSepcs[0]),
            CpuSize = double.Parse(partSepcs[1]),
            Material = partSepcs[2]
        };

        if (ultron.Torso == null)
        {
            ultron.Torso = newTorso;
        }
        else if (newTorso.EnergyConsumption < ultron.Torso.EnergyConsumption)
        {
            ultron.Torso = newTorso;
        }
    }

    static void GetHead(Ultron ultron, string[] partSepcs)
    {
        Head newHead = new Head
        {
            EnergyConsumption = int.Parse(partSepcs[0]),
            IQ = int.Parse(partSepcs[1]),
            Material = partSepcs[2]
        };

        if (ultron.Head == null)
        {
            ultron.Head = newHead;
        }
        else if (newHead.EnergyConsumption < ultron.Head.EnergyConsumption)
        {
            ultron.Head = newHead;
        }
    }
}

class Ultron
{
    public Head Head { get; set; }
    public Torso Torso { get; set; }
    public List<Arm> Arms = new List<Arm>();
    public List<Leg> Legs = new List<Leg>();
    public long TotalEnergy
    {
        get
        {
            int totalEnergy = Head != null ? Head.EnergyConsumption : 0;
            totalEnergy += Torso != null ? Torso.EnergyConsumption : 0;
            foreach (Arm arm in Arms)
            {
                totalEnergy += arm.EnergyConsumption;
            }
            foreach (Leg leg in Legs)
            {
                totalEnergy += leg.EnergyConsumption;
            }

            return totalEnergy;
        }
    }
}

class Head
{
    public int EnergyConsumption { get; set; }
    public int IQ { get; set; }
    public string Material { get; set; }

    public override string ToString()
    {
        string output = "#Head:\r\n";
        output += $"###Energy consumption: {EnergyConsumption}\r\n";
        output += $"###IQ: {IQ}\r\n";
        output += $"###Skin material: {Material}";
        return output;
    }
}

class Torso
{
    public int EnergyConsumption { get; set; }
    public double CpuSize { get; set; } // in cm
    public string Material { get; set; }

    public override string ToString()
    {
        string output = $"#Torso:\r\n";
        output += $"###Energy consumption: {EnergyConsumption}\r\n";
        output += $"###Processor size: {CpuSize:f1}\r\n";
        output += $"###Corpus material: {Material}";
        return output;
    }
}

class Arm
{
    public int EnergyConsumption { get; set; }
    public int ReachDistance { get; set; }
    public int FingersCount { get; set; }

    public override string ToString()
    {
        string output = $"#Arm:\r\n";
        output += $"###Energy consumption: {EnergyConsumption}\r\n";
        output += $"###Reach: {ReachDistance}\r\n";
        output += $"###Fingers: {FingersCount}";
        return output;
    }
}

class Leg
{
    public int EnergyConsumption { get; set; }
    public int Strenght { get; set; }
    public int Speed { get; set; }

    public override string ToString()
    {
        string output = $"#Leg:\r\n";
        output += $"###Energy consumption: {EnergyConsumption}\r\n";
        output += $"###Strength: {Strenght}\r\n";
        output += $"###Speed: {Speed}";
        return output;
    }
}