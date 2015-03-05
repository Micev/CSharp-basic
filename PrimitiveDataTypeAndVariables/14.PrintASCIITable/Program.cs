using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.PrintASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 255; i++)
            {
                char symbol = (char)i;
                Console.WriteLine("Number: {0} has character: {1}", i, symbol);
            }
        }
    }
}
