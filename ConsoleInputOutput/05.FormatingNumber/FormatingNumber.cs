using System;
class FormatingNumber
{
    static void Main(string[] args)
    {
        Console.Write("Enter a (0<a<500) = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter float b = ");
        float b = float.Parse(Console.ReadLine());
        Console.Write("Enter float c = ");
        float c = float.Parse(Console.ReadLine());

        Console.WriteLine("|{0,-10:X}|{1}|{2,10}|{3,-10:0.000}|",a,Convert.ToString(a,2).PadLeft(10,'0'),b,c);

    }
}

