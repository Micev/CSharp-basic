﻿using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter n = ");
        int n = int.Parse(Console.ReadLine());
        int p = 3;
        int nRightP = n >> p;      
        int bit = nRightP & 1;     
        Console.WriteLine(bit);    
    }
}

