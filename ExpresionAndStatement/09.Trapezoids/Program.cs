﻿using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter side a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter side b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter height h = ");
        double h = double.Parse(Console.ReadLine());
        double area = ((a + b) / 2) * h;
        Console.WriteLine("Area of trapezoid is " + area);
    }
}

