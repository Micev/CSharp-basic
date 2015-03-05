using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n =");
            int n = int.Parse(Console.ReadLine());
            int a = 0;
            int b = 1;
            int c = 1;
            for (int i = 0; i < n; i++)
            {
                Console.Write(a+" ");
                c = a + b;
                a = b;
                b = c;
            }
            Console.WriteLine();
        }
    }
}
