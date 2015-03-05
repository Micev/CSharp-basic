using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your weight: ");
        double weight = int.Parse(Console.ReadLine());
        Console.WriteLine("Your weight on the moon is : {0}",weight*0.17);
    }
}

