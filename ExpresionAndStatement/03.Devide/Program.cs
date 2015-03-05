using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        if (number%7==0 & number%5==0)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}

