using System;
using System.Linq;
class Program
{
    static void Main() // 100/100
    {
        int sizeField = int.Parse(Console.ReadLine());
        int[] indexesToPlantBugs = Console.ReadLine().Split().Select(int.Parse).ToArray();
        string[] commandInput = Console.ReadLine().Split();

        int[] field = PlantBugsOnField(sizeField, indexesToPlantBugs);

        while (commandInput[0] != "end")
        {
            int bugIndex = int.Parse(commandInput[0]);
            string flightDirection = commandInput[1];
            int flightLength = int.Parse(commandInput[2]);

            flightDirection = FlightDirectionCorrection(flightDirection, flightLength);

            //Check for misleading index input
            if (bugIndex >= 0 && bugIndex < sizeField)
            {
                if (field[bugIndex] == 1) //Check if there is an actual bug on that index
                {
                    //Take off and leave index empty => 0
                    field[bugIndex] = 0;

                    //land LEFT                
                    if (flightDirection == "left")
                    {
                        field = NewFieldLeft(field, bugIndex, flightLength);
                    }// END OF LEFT direction ---------------------------------


                    //land RIGHT  
                    if (flightDirection == "right")
                    {
                        field = NewFieldRight(field, bugIndex, flightLength);
                    }// END OF RIGHT direction -------------------------------


                }//END OF Check if there is an actual bug on that index
            } //END OF Check for misleading input index

            commandInput = Console.ReadLine().Split();

        } // END OF while (commandInput[0] != "end")

        // Print output
        Console.WriteLine(string.Join(" ", field));
    }
    
    //LEFT LAND direction / land if index is 0
    static int[] NewFieldLeft(int[] field, int bugIndex, int flightLength)
    {
        flightLength = Math.Abs(flightLength);
        for (int i = bugIndex - flightLength; i >= 0; i = i - flightLength)
        {
            if (field[i] == 0)
            {
                field[i] = 1;
                break;
            }
        }
        return field;
    } // end of LEFT LAND ----------------------------

    //RIGHT land
    private static int[] NewFieldRight(int[] field, int bugIndex, int flightLength)
    {
        flightLength = Math.Abs(flightLength);
        for (int i = bugIndex + flightLength; i < field.Length; i = i + flightLength)
        {
            if (field[i] == 0)
            {
                field[i] = 1;
                break;
            }
        }

        return field;
    }// end of RIGHT LAND ----------------------------
    
    //Correct flight direction (left/right) based on positive or negative flight lenght
    static string FlightDirectionCorrection(string flightDirection, int flightLength)
    {
        string correctedDirection = flightDirection;
        if (flightLength < 0)
        {
            switch (flightDirection)
            {
                case "left": correctedDirection = "right"; break;
                case "right": correctedDirection = "left"; break;
            }
        }
        return correctedDirection;
    }
    // END OF Correct flight ------------------------------
    
    // Plant bugs on field - the very first task
    static int[] PlantBugsOnField(int sizeField, int[] indexToPlantBugs)
    {
        int[] field = new int[sizeField];
        for (int i = 0; i < indexToPlantBugs.Length; i++)
        {
            if (indexToPlantBugs[i] >= 0 && indexToPlantBugs[i] < sizeField)
            {
                field[indexToPlantBugs[i]] = 1;
            }
        }
        return field;
    }
}