using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter number from 1000 to 9999: ");
        int number = int.Parse(Console.ReadLine());
        int a = number / 1000;
        int b = number / 100;
        b %= 10;
        int c = number / 10;
        c %= 10;
        int d = number % 10;
        Console.WriteLine("sum of digits : {0}",a+b+c+d);
        Console.WriteLine("reversed : {0}{1}{2}{3}",d,c,b,a);
        Console.WriteLine("last digit in front : {0}{1}{2}{3}", d, a, b, c);
        Console.WriteLine("exchnge between second and third digits : {0}{1}{2}{3}", a, c, b, d);


    }
}

