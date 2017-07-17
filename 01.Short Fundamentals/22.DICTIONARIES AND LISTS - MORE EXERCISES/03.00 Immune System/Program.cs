using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main()
    {
        double startHealth = double.Parse(Console.ReadLine());
        bool isDefeated = true;

        double beginHealth = startHealth;

        while (true)
        {
            string virusName = Console.ReadLine();
            if (virusName == "end")
            {
                break;
            }
            decimal sum = 0;
            for (int i = 0; i < virusName.Length; i++)
            {
                sum += Convert.ToInt32(virusName[i]);
            }
            int virusStrength = (int)Math.Floor(sum / 3);
            int lenght = virusName.Length;
            int virusDefeatSeconds = virusStrength * lenght;

            int minutes = (int)virusDefeatSeconds / 60;
            int secounds = (int)virusDefeatSeconds % 60;
            startHealth -= virusDefeatSeconds;
           

            Console.WriteLine("Virus {0}: {1} => {2} seconds", virusName, virusStrength, virusDefeatSeconds);
            Console.WriteLine("{0} defeated in {1}m {2}s.", virusName, minutes, secounds);
            Console.WriteLine("Remaining health: {0}", startHealth);
            //startHealth *= 1.2;

            //if (startHealth > beginHealth)
            //{
            //    startHealth = beginHealth;
            //}


            if (startHealth <= 0)
            {
                isDefeated = false;
            }

        }
        if (isDefeated)
        {
            Console.WriteLine("Final Health: {0}", startHealth);
        }
        else
        {
            Console.WriteLine("Immune System Defeated.");
        }

    }
}

