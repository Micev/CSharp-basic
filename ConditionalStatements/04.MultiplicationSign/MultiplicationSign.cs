using System;
class MultiplicationSign
{
    static void Main(string[] args)
    {
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());
        if (a>0)
        {
            if (b>0 && c>0)
            {
                Console.WriteLine("+");
            }
            else if(b<0 && c<0)
            {
                Console.WriteLine("+");
            }
            else
            {
                Console.WriteLine("-");
            }
        }
        else if(a<0)
        {
            if (b > 0 && c > 0)
            {
                Console.WriteLine("-");
            }
            else if (b < 0 && c < 0)
            {
                Console.WriteLine("-");
            }
            else
            {
                Console.WriteLine("+");
            }
        }
        else
        {
            Console.WriteLine(0);
        }
    }
}

