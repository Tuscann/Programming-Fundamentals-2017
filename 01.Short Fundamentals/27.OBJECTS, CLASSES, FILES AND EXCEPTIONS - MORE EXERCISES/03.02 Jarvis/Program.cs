using System;
using System.Collections.Generic;
using System.Linq;

public class Robot
{
    public List<Head> Heads { get; set; }
    public List<Arms> Arms { get; set; }
    public List<Legs> Legs { get; set; }
    public List<Torso> Torsos { get; set; }
}
public class Head
{
    public int EnergyConsumption { get; set; }
    public int IQ { get; set; }
    public string Material { get; set; }
}
public class Torso
{
    public int EnergyConsumption { get; set; }
    public decimal ProcessorSize { get; set; }
    public string Material { get; set; }
}
public class Arms
{
    public int EnergyConsumption { get; set; }
    public int ArmsLenght { get; set; }
    public int CountFingers { get; set; }
}
public class Legs
{
    public int EnergyConsumption { get; set; }
    public int Strenght { get; set; }
    public int Speed { get; set; }
}


public class Program
{
    public static void Main() // 100/100
    {
        long totalEnergy = long.Parse(Console.ReadLine());
        Robot robot = new Robot();
        while (true)
        {
            string[] line = Console.ReadLine().Split();
            if (line[0] == "Assemble!")
                break;
            string part = line[0];
            int currEnergyCons = int.Parse(line[1]);

            if (part == "Head")
            {
                Head currentHead = new Head();
                currentHead.EnergyConsumption = currEnergyCons;
                currentHead.IQ = int.Parse(line[2]);
                currentHead.Material = line[3];
                if (robot.Heads == null)
                    robot.Heads = new List<Head>();
                robot.Heads.Add(currentHead);
            }
            else if (part == "Torso")
            {
                Torso currentTorso = new Torso();
                currentTorso.EnergyConsumption = currEnergyCons;
                currentTorso.ProcessorSize = decimal.Parse(line[2]);
                currentTorso.Material = line[3];
                if (robot.Torsos == null)
                    robot.Torsos = new List<Torso>();
                robot.Torsos.Add(currentTorso);
            }
            else if (part == "Arm")
            {
                Arms currArm = new Arms();
                currArm.EnergyConsumption = currEnergyCons;
                currArm.ArmsLenght = int.Parse(line[2]);
                currArm.CountFingers = int.Parse(line[3]);
                if (robot.Arms == null)
                    robot.Arms = new List<Arms>();
                robot.Arms.Add(currArm);
            }
            else if (part == "Leg")
            {
                Legs currLeg = new Legs();
                currLeg.EnergyConsumption = currEnergyCons;
                currLeg.Strenght = int.Parse(line[2]);
                currLeg.Speed = int.Parse(line[3]);
                if (robot.Legs == null)
                    robot.Legs = new List<Legs>();
                robot.Legs.Add(currLeg);
            }
        }
        if (robot.Arms == null)
            robot.Arms = new List<Arms>();
        if (robot.Legs == null)
            robot.Legs = new List<Legs>();
        if (robot.Heads == null)
            robot.Heads = new List<Head>();
        if (robot.Torsos == null)
            robot.Torsos = new List<Torso>();

        if (robot.Arms.Count > 1 && robot.Heads.Count > 0 &&
            robot.Legs.Count > 1 && robot.Torsos.Count > 0)
        {
            long consumedEnergy =
                robot.Arms.OrderBy(x => x.EnergyConsumption).First().EnergyConsumption +
                robot.Arms.OrderBy(x => x.EnergyConsumption).Skip(1).Take(1).First().EnergyConsumption +
                robot.Legs.OrderBy(x => x.EnergyConsumption).First().EnergyConsumption +
                robot.Legs.OrderBy(x => x.EnergyConsumption).Skip(1).Take(1).First().EnergyConsumption +
                robot.Heads.OrderBy(x => x.EnergyConsumption).First().EnergyConsumption +
                robot.Torsos.OrderBy(x => x.EnergyConsumption).First().EnergyConsumption;
            if (consumedEnergy > totalEnergy)
                Console.WriteLine("We need more power!");
            else
            {
                Console.WriteLine("Jarvis:");
                foreach (Head item in robot.Heads.OrderBy(x => x.EnergyConsumption).Take(1))
                {
                    Console.WriteLine($"#Head:");
                    Console.WriteLine($"###Energy consumption: {item.EnergyConsumption}");
                    Console.WriteLine($"###IQ: {item.IQ}");
                    Console.WriteLine($"###Skin material: {item.Material}");
                }
                foreach (Torso item in robot.Torsos.OrderBy(x => x.EnergyConsumption).Take(1))
                {
                    Console.WriteLine($"#Torso:");
                    Console.WriteLine($"###Energy consumption: {item.EnergyConsumption}");
                    Console.WriteLine($"###Processor size: {item.ProcessorSize:f1}");
                    Console.WriteLine($"###Corpus material: {item.Material}");
                }
                foreach (Arms item in robot.Arms.OrderBy(x => x.EnergyConsumption)
                    .Take(2))
                {
                    Console.WriteLine($"#Arm:");
                    Console.WriteLine($"###Energy consumption: {item.EnergyConsumption}");
                    Console.WriteLine($"###Reach: {item.ArmsLenght}");
                    Console.WriteLine($"###Fingers: {item.CountFingers}");
                }
                foreach (Legs item in robot.Legs.OrderBy(x => x.EnergyConsumption)
                    .Take(2))
                {
                    Console.WriteLine($"#Leg:");
                    Console.WriteLine($"###Energy consumption: {item.EnergyConsumption}");
                    Console.WriteLine($"###Strength: {item.Strenght}");
                    Console.WriteLine($"###Speed: {item.Speed}");
                }
            }
        }
        else
            Console.WriteLine("We need more parts!");
    }
}
