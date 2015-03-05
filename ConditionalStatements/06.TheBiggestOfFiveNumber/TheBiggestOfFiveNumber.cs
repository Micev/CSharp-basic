using System;

class TheBiggestOfFiveNumber
{
    static void Main(string[] args)
    {
        Console.Write("a=");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b=");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c=");
        double c = double.Parse(Console.ReadLine());
        Console.Write("d=");
        double d = double.Parse(Console.ReadLine());
        Console.Write("e=");
        double e = double.Parse(Console.ReadLine());
        double x, y, z;

        if (a >= b) x = a;
        else        x = b;
        if (c >= d) y = c;
        else        y = d;
        if (x >= y) z = x;
        else        z = y;
        if(z>=e)
        {
            Console.WriteLine("Biggest number = {0}",z);
        }
        else
        {
            Console.WriteLine("Biggest number = {0}",e);
        }



    }
}

