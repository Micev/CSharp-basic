using System;

class CirclePerimeterAndArea
{
    static void Main(string[] args)
    {
        Console.Write("Enter radius of circle = ");
        double r = double.Parse(Console.ReadLine());
        Console.WriteLine("Perimeter : {0:0.00}\r\nArea : {1:0.00}",(Math.PI*2*r),(Math.PI*(r*r)));
    }
}

