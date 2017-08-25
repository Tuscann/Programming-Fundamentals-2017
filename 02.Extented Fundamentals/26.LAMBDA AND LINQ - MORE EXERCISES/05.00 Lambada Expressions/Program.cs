using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main() // 60/100
    {
        var dic = new Dictionary<string, string>();

        while (true)
        {
            string az = Console.ReadLine();
            if (az == "lambada")
            {
                break;
            }
            if (az == "dance")
            {
                dic = dic.ToDictionary(x => x.Key, x => $"{x.Key}.{x.Value}");
            }
            else
            {
                List<string> current = az.Split(new[] { " => " }, StringSplitOptions.RemoveEmptyEntries).ToList();

                string selector = current[0];
                string selectorObjectProperty = current[1];

                dic[selector] = selectorObjectProperty;
            }
        }
        foreach (var selector in dic)
        {
            Console.Write("{0} => {1}", selector.Key, selector.Value);
        }
    }
}