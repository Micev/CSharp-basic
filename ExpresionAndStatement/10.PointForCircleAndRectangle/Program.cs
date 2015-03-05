using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter x = ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter y = ");
        double y = double.Parse(Console.ReadLine());
        bool isInCircle = Math.Pow(x - 1, 2) + Math.Pow(y - 1, 2) <= Math.Pow(1.5, 2);
        bool isOutsideRectangle = x > 1 || x < 6 && y > -1 || y < 2;

        if (isInCircle == true && isOutsideRectangle == true)
        {
            Console.WriteLine("Expresion true");
        }
        else
        {
            Console.WriteLine("Expresion false");
        }
    }
}



