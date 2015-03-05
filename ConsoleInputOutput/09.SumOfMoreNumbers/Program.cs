using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.SumOfMoreNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of numbers that you want to sum : ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.Write("Enter a number= ");
                sum += int.Parse(Console.ReadLine());

            }
            Console.WriteLine("Sum = "+sum);
        }
    }
}
