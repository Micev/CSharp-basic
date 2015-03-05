using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        number = number / 100;
        number = number % 10;
        if (number==7)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
        
    }
}

