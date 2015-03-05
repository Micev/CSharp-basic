using System;
class BeerTime
{
    static void Main(string[] args)
    {
        try
        {

            Console.Write("enters a time in format (hh:mm tt): ");
            string input = Console.ReadLine();
            DateTime time = Convert.ToDateTime(input);

            if (time.Hour > 12) 
            {
                Console.WriteLine("Beer Time");
            }
            else if (time.Hour<3)
            {
                Console.WriteLine("Beer time");
            }
            else
            {
                Console.WriteLine("non-beer time");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid Time");
            
        }
    }
}

