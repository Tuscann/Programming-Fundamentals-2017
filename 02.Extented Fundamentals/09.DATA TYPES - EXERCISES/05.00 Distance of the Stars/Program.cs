using System;
class DistanceOfTheStars
{
    static void Main() // 100/100
    {
        decimal fromEarthToNearestStar = 4.22m;
        decimal toCenterOfMilkyWay = 26000m;
        decimal diameterOfMilkyWay = 100000m;
        decimal fromEarthToEdgeOfUniverse = 46500000000m;

        Console.WriteLine((fromEarthToNearestStar * 9450000000000).ToString("e2"));
        Console.WriteLine((toCenterOfMilkyWay * 9450000000000).ToString("e2"));
        Console.WriteLine((diameterOfMilkyWay * 9450000000000).ToString("e2"));
        Console.WriteLine((fromEarthToEdgeOfUniverse * 9450000000000).ToString("e2"));
    }
}