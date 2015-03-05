using System;
class QuadraticEquation
{
    static void Main(string[] args)
    {
        Console.WriteLine("ax2 + bx + c = 0\r\n");
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("c = ");
        int c = int.Parse(Console.ReadLine());
        double d = (b * b) - (4 * a * c);
        double x1 = (-b - Math.Sqrt(d)) / (2 * a);
        double x2 = (-b + Math.Sqrt(d)) / (2 * a);

        Console.WriteLine("X1 = {0}\r\nX2 = {1}",x1,x2);
    }
}

