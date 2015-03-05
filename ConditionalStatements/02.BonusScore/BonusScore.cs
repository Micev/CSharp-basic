using System;
class BonusScore
{
    static void Main(string[] args)
    {
        Console.Write("Enter number [0...9] = ");
        int num = int.Parse(Console.ReadLine());

        if (num>=1 && num<=3)
        {
            Console.WriteLine("result = {0}",num*10);
        }
        else if (num>=4 && num<=6)
        {
            Console.WriteLine("result = {0}",num*100);
        }
        else if (num >= 7 && num <= 9)
        {
            Console.WriteLine("result = {0}", num * 1000);
        }
        else
        {
            Console.WriteLine("invalid score!!!");
        }

    }
}
