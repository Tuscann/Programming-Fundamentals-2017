using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main()
    {
        Dictionary<string, Dictionary<string, List<double>>> dic = new Dictionary<string, Dictionary<string, List<double>>>();
        while (true)
        {

            List<string> curentrow = Console.ReadLine().Split(' ').ToList();
            if (curentrow[0] + curentrow[1] == "filterbase")
            {
                break;
            }
            string name = curentrow[0];

            int x1 = 0;
            double x2 = 0;
            bool integer = int.TryParse(curentrow[2], out x1);
            bool doouble = double.TryParse(curentrow[2], out x2);
            string x3;

            if (integer)
            {
                Console.WriteLine(integer);
            }
            if (doouble)
            {
                Console.WriteLine(doouble);
            }
            





            if (!dic.ContainsKey(name))
            {
                dic[name] = new Dictionary<string, List<double>>();
                //dic[name].Add();
            }


        }
        string comand = Console.ReadLine();





        Console.WriteLine("{0}", new string('=', 20));


    }
}

