using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter first number: ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        double secondNumber = double.Parse(Console.ReadLine());
        decimal compareNumber = (decimal)Math.Abs(firstNumber - secondNumber);
        bool compareBool = (Math.Abs(firstNumber - secondNumber) < 0.000001);
        compareNumber = Math.Round(compareNumber, 6);
        if (compareBool)
        {
            Console.WriteLine("The difference {0} < eps", compareNumber);

        }
        else if (compareNumber == 0.000001m)
            {
                Console.WriteLine("Border case. The difference {0} == eps. We consider the numbers are different.", compareNumber);
            }
            else
            {
                Console.WriteLine("The difference of {0} is too big (> eps)", compareNumber);
            }
    }
}

