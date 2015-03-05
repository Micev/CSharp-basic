using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("enter number 0-100 : ");
        int number = int.Parse(Console.ReadLine());
		int div = 2;
		int maxDiv = (int) Math.Sqrt(number);
		bool prime = true;
		while (prime && (div <= maxDiv)) {
		if (number % div == 0) {
		prime = false;
		}
		div++;
		}

		if(prime==true)
		    Console.WriteLine("{0} is Prime",number);
		else
            Console.WriteLine("{0} is not Prime",number);

    }
}

