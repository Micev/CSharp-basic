using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your Birthday (dd.mm.yyyy)!!! : ");
        DateTime YourBirthDay = DateTime.Parse(Console.ReadLine());
        DateTime DateNow = DateTime.Today;
        int CurrentAge = DateNow.Year - YourBirthDay.Year;
        if (DateNow.Month < YourBirthDay.Month)
        {
            Console.WriteLine("You are {0} years old",CurrentAge-1);
            Console.WriteLine("After 10 years you will be {0} ", CurrentAge + 9);
        }
        else if (DateNow.Month == YourBirthDay.Month)
        {
            if (DateNow.Day > YourBirthDay.Day)
            {
                Console.WriteLine("You are {0} years old", CurrentAge-1);
                Console.WriteLine("After 10 years you will be {0} ", CurrentAge + 9);
            }
            else
            {
                Console.WriteLine("You are {0} years old", CurrentAge);
                Console.WriteLine("After 10 years you will be {0} ", CurrentAge + 10);
            }
        }
        else
        {
            Console.WriteLine("You are {0} years old", CurrentAge);
            Console.WriteLine("After then years you will be {0} ", CurrentAge + 10);
        }
    }
}

