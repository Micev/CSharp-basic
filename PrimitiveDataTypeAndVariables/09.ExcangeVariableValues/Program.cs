using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.ExcangeVariableValues
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = 5;
            byte b = 10;
            byte c;
            Console.WriteLine("Variable before exchange : a= {0} b= {1}",a,b);
            c = a;
            a = b;
            b = c;
            Console.WriteLine("Variable after exchange : a= {0} b= {1}", a, b);
        }
    }
}
