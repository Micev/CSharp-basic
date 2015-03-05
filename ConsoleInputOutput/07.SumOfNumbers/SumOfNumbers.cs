using System;
class SumOfNumbers
{
    static void Main(string[] args)
    {
        
        Console.Write("Enter five number separed by space: ");
        string number = Console.ReadLine();
        int sum=0;
        for (int i = 0; i < 5; i++)
        {
            sum += Convert.ToInt32(number.Split(' ')[i]);
        }
        Console.WriteLine(sum);
        
        
    }
}

