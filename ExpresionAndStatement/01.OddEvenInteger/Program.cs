using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        if (number%2!=0)
        {
            Console.WriteLine("Number is odd");
        }
        else
        {
            Console.WriteLine("Number is even");
        }
    }
}

