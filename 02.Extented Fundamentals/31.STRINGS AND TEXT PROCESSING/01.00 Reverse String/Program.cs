﻿using System;
class Program
{
    static void Main() // 100/100
    {
        string input = Console.ReadLine();
        string print = String.Empty;
        for (int i = input.Length - 1; i >= 0; i--)
        {
            print += input[i];
        }
        Console.WriteLine(print);
    }
}