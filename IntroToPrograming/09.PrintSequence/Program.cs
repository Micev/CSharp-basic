using System;
class Program
{
    static void Main(string[] args)
    {
        for (int i = 2; i < 12; i++)
        {
            Console.WriteLine(i%2==0 ? i : -i);
        }
    }
}

