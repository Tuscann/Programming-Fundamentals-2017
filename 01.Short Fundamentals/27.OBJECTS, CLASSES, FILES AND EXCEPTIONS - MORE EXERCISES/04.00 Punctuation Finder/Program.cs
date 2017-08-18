using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

class P04_PunctuationFinder
{
    static void Main() // 100/100
    {
        string text = File.ReadAllText(@"C:\Users\todor\Desktop\sample_text.txt");
        List<char> result = text.ToCharArray().Where(c => new char[] { '.', ',', '!', '?', ':' }.Contains(c)).ToList();
        Console.WriteLine(string.Join(", ", result));



        //Output - copy=>paste=>submit=>judge.softuni.bg
        /*,, ,, ., ,, ., ., ,, !, ,, ,, :, ,, ., ,, ,, ,, ,, ., ,, ,, ?, ,, ?, ,, ,, ., ,, ,, ,, ,, ., ,, ,, ., ,, ,, ?, ,, ?, ,, ,, ., ., ,, ,, ,, ., ., ,, ., ,, ,, ,, :, ., ., ,, ,, ., ., :, ,, .
         */
    }
}
