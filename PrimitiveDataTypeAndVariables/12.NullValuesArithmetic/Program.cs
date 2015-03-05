using System;
class Program
{
    static void Main(string[] args)
    {
        int? number = null;
        double? dNumber = null;

        if (number == null)
        {
            Console.WriteLine("number has value null");
        }
        if (dNumber == null)
        {
            Console.WriteLine("dNumber has value null");
        }
        number = number + 5;
        dNumber = number?? 3.43;
        Console.WriteLine("New value of number: " + number);
        Console.WriteLine("New value of dnumber: " + dNumber);
    
        number = 4;
        dNumber = 9.12345;
        Console.WriteLine("New value of number: " + number);
        Console.WriteLine("New value of dnumber: " + dNumber);
    }
}

