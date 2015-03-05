using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("enter x: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("enter y: ");
        double y = double.Parse(Console.ReadLine());
        bool point = Math.Pow(x, 2) + Math.Pow(y, 2) <= Math.Pow(2, 2);
        if (point)
        {
            Console.WriteLine("Point is inside.");
        }
        else
        {
            Console.WriteLine("Point is outside.");
        }
    }
}

