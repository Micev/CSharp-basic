using System;
class IntDoubleString
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please choose a type:\r\n1 --> int\r\n2 --> double\r\n3 --> string");
        string choose = Console.ReadLine();

        switch (choose)
        {
            case "1":
                Console.Write("Please enter a int: ");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine(x + 1); break;
            case "2":
                Console.Write("Please enter a double: ");
                double y = double.Parse(Console.ReadLine());
                Console.WriteLine(y + 1); break;
            case "3":
                Console.Write("Please enter a string: ");
                string str = Console.ReadLine();
                Console.WriteLine(str + "*"); break;
            default:
                Console.WriteLine("Incorrect input"); break;

        }
    }
}

