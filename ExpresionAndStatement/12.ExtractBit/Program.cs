using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Entre bit index = ");
        int p = int.Parse(Console.ReadLine());
        int nRightp = n >> p;
        int bit = nRightp & 1;
        Console.WriteLine("Your bit hava value : {0}",bit);

    }
}

