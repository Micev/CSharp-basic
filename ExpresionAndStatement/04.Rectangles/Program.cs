using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter weight of rectangle: ");
        double weight = double.Parse(Console.ReadLine());
        Console.Write("Enter height of rectangle: ");
        double height = double.Parse(Console.ReadLine());
        Console.WriteLine("Perimeter is : {0}",((weight*2)+(height*2)));
        Console.WriteLine("Area is : {0}",weight*height);
    }
}

