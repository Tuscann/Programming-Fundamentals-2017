using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split('|').ToArray();

        for (int i = 0; i < input.Length; i++)
        {
            var curinet = input[i].ToCharArray();
            int sum = 0;
            int secoundsum = 0;
            int zerous = 0;
            int ones = 0;
            char last = 'a';

            for (int j = 0; j < curinet.Length; j++)
            {
                if (curinet[j] == '0')
                {
                    zerous++;
                }
                if (curinet[j] == '1')
                {
                    ones++;
                }
                if (j == 0)
                {
                    last = curinet[j];
                    continue;
                   
                }
                else
                {
                    if (last == '0' && curinet[j] == '0')
                    {
                        secoundsum++;
                    }
                    if (last == '1' && curinet[j] == '1')
                    {
                        secoundsum++;
                    }
                    last = curinet[j];
                    
                }
            }
            sum = zerous * 3 + ones * 5;
      
            //Console.WriteLine((sum));
            //Console.WriteLine(secoundsum);
            Console.WriteLine((char)(sum + secoundsum));




        }


    }
}

