using System;
class NumberComparer
{
    static void Main(string[] args)
    {
        Console.Write("Enter a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter b = ");
        int b = int.Parse(Console.ReadLine());

        if (a>=b)
        {
            Console.WriteLine(a);
        }
        else
        {
            Console.WriteLine(b);
        }
    }
}

