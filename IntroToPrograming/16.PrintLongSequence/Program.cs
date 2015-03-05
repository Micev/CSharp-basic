using System;

class Program
{
    static void Main(string[] args)
    {
        Console.BufferHeight = 1001;
        for (int i = 2; i < 1002; i++)
        {
            Console.WriteLine(i%2==0 ? i : -i);            
        }
    }
}

