using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Entre bit index = ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("Enter value of Modify bit 0 or 1 = ");
        int v = int.Parse(Console.ReadLine());
        int nRightp = n >> p;
        int mask = 1 << p;
        if (((mask & n) == 0) && v == 1)
        {
            n += mask;
            Console.WriteLine(n);
        }
        else if (((mask & n) == 1) && v == 10)
        {
            n -= mask;
            Console.WriteLine(n);
        }
        else
        {
            Console.WriteLine(n);
        }
    }
}

