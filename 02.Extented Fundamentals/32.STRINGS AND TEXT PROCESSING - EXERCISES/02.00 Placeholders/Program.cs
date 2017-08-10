using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
class Program
{
    static void Main()
    {
        //string patterAfter = @"->([a-z, ]*)";
        //string patterPlaceHolders = @"({[0-9]})";
        List<string> list = new List<string>();

        while (true)
        {
            string current = Console.ReadLine();
            if (current == "end")
            {
                break;
            }
            List<string> x = current.Split().ToList();
            string empty = String.Empty;

            foreach (string word in x)
            {
                if (word == "->")
                {

                    break;
                }
                empty += word + " ";
            }
            list.Add(empty);
            int index = current.IndexOf("->");
            List<char> after = current.Skip(index + 2).ToList();
            Console.WriteLine(string.Join("", after));





        }


    }
}

