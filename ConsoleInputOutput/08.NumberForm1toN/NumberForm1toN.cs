using System;
class NumberForm1toN
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter n=  ");

        int number = int.Parse(Console.ReadLine());

        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine(i);
        }
    }
}

