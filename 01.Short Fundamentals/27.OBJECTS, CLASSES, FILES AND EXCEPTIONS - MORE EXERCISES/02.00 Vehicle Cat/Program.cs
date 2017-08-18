using System;
using System.Collections.Generic;
using System.Linq;

class P02_VehicleCatalogue
{
    static void Main() // 100/100
    {
        List<Vehilce> catalog = new List<Vehilce>();
        GetVehicles(catalog);
        PrintVehiclesByRequest(catalog);
        PrintAverageHp(catalog, true);
        PrintAverageHp(catalog, false);
    }

    static void PrintAverageHp(List<Vehilce> catalog, bool isCar)
    {
        List<Vehilce> hpList = catalog
            .Where(type => type.IsCar == isCar)
            .ToList();
        double averageHp = hpList.Count == 0 ?
            0.0 :
            hpList.Select(v => (double)v.Horsepower)
                .Average();
        string vehicleType = isCar ? "Car" : "Truck";
        Console.WriteLine($"{vehicleType}s have average horsepower of: {averageHp:f2}.");
    }

    static void PrintVehiclesByRequest(List<Vehilce> catalog)
    {
        string brand = Console.ReadLine();

        while (brand != "Close the Catalogue")
        {
            Console.WriteLine(catalog.First(v => v.Brand == brand));

            brand = Console.ReadLine();
        }
    }

    static void GetVehicles(List<Vehilce> catalog)
    {
        string command = Console.ReadLine();

        while (command != "End")
        {
            string[] vehicleInfo = command.Split(' ');
            Vehilce newVehicle = new Vehilce
            {
                IsCar = vehicleInfo[0].ToLower() == "car",
                Brand = vehicleInfo[1],
                Color = vehicleInfo[2],
                Horsepower = short.Parse(vehicleInfo[3])
            };

            catalog.Add(newVehicle);

            command = Console.ReadLine();
        }
    }
}

class Vehilce
{
    public bool IsCar { get; set; }
    public string Brand { get; set; }
    public string Color { get; set; }
    public short Horsepower { get; set; }

    public override string ToString()
    {
        string vehicleType = IsCar ? "Car" : "Truck";
        string output = $"Type: {vehicleType}\r\n";
        output += $"Model: {Brand}\r\n";
        output += $"Color: {Color}\r\n";
        output += $"Horsepower: {Horsepower}";
        return output;
    }
}