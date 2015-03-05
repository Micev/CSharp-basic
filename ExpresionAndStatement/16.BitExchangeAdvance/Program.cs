using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter a number: ");
        var n = long.Parse(Console.ReadLine());

        Console.Write("Please enter \"p\": ");
        var p = sbyte.Parse(Console.ReadLine());

        Console.Write("Please enter \"q\": ");
        var q = sbyte.Parse(Console.ReadLine());

        Console.Write("Please enter \"k\": ");
        var k = sbyte.Parse(Console.ReadLine());

        var mask = 0;

        if (Math.Max(p, q) + k > 32)
        {
            Console.WriteLine("Out of range");
        }
        else if (Math.Min(p, q) + k > Math.Max(p, q))
        {
            Console.WriteLine("Overlapping");
        }
        else
        {
            while (k > 0)
            {
                k--;
                mask += (int)Math.Pow(2, k);
            }

            long firstBits = mask << p;
            long secondBits = mask << q;
            long checkFirst = n & firstBits;
            long checkSecond = n & secondBits;
            long change = (n & ~firstBits) & ~secondBits;
            long changeFirstBits = (checkFirst >> p) << q;
            long changeSecondBits = (checkSecond >> q) << p;
            long result = (change | changeFirstBits) | changeSecondBits;

            
            Console.WriteLine("Result:                     {0}", result);

            Console.WriteLine("\n\n");
        }
    }
}

