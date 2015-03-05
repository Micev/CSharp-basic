using System;
using System.Text;
class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        char symbol = '©';
        Console.WriteLine("   {0}\n  {0}{0}\n {0}  {0}\n{0}{0}{0}{0}",symbol);
    }
}

