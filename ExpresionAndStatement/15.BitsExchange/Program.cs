using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter a number:");
        long number = long.Parse(Console.ReadLine());


        long firstBits = 7 << 3;
        long secondBits = 7 << 24;
        long checkFirst = number & firstBits;
        long checkSecond = number & secondBits;
        long change = (number & ~firstBits) & ~secondBits;
        long changeFirstBits = (checkFirst >> 3) << 24;
        long changeSecondBits = (checkSecond >> 24) << 3;
        long result = (change | changeFirstBits) | changeSecondBits;

        Console.WriteLine("Binary representation: " + Convert.ToString(number, 2).PadLeft(32, '0'));
        Console.WriteLine("Binary result:         " + Convert.ToString(result, 2).PadLeft(32, '0'));
        Console.WriteLine("Result:                {0}", result);

        Console.WriteLine("\n\n");
    }
}

