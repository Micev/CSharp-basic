using System;
class NumberAsWords
{
    static void Main(string[] args)
    {
        Console.Write("Enter number (0...999): ");
        int n = int.Parse(Console.ReadLine());
        int n1 = 1001;
        int cnt = 0;
        while (cnt < 3)
        {
            cnt = cnt + 1;
            if (n % 100 != 0 && cnt == 1)
            {
                n1 = n - n % 100;
                
            }
            if (n % 100 == 0 && cnt == 1) 
            { 
                n1 = n;
                cnt = 3; 
            }
            if (n1 >= 10 && n1 < 100 && cnt == 2) 
                Console.Write("and ");
            if (n1 == 0) n1 = 1001;

            switch (n1)
            {
                case 0: Console.Write("zero "); break;
                case 1: Console.Write("One "); break;
                case 2: Console.Write("two "); break;
                case 3: Console.Write("three "); break;
                case 4: Console.Write("four "); break;
                case 5: Console.Write("five "); break;
                case 6: Console.Write("six "); break;
                case 7: Console.Write("seven "); break;
                case 8: Console.Write("eight "); break;
                case 9: Console.Write("nine "); break;
                case 10: Console.Write("ten "); break;
                case 11: Console.Write("eleven "); break;
                case 12: Console.Write("twelve "); break;
                case 13: Console.Write("thirteen "); break;
                case 14: Console.Write("fourteen "); break;
                case 15: Console.Write("fiveteen "); break;
                case 16: Console.Write("sixteen "); break;
                case 17: Console.Write("seventeen "); break;
                case 18: Console.Write("eighteen "); break;
                case 19: Console.Write("nineteen "); break;
                case 20: Console.Write("twenty "); break;
                case 30: Console.Write("thirty "); break;
                case 40: Console.Write("forty "); break;
                case 50: Console.Write("fifty "); break;
                case 60: Console.Write("sixty "); break;
                case 70: Console.Write("seventy "); break;
                case 80: Console.Write("eighty "); break;
                case 90: Console.Write("ninety "); break;
                case 100: Console.Write("One hundred "); break;
                case 200: Console.Write("Two hundred "); break;
                case 300: Console.Write("Tree hundred "); break;
                case 400: Console.Write("Four hundred "); break;
                case 500: Console.Write("Five hundred "); break;
                case 600: Console.Write("Six hundred "); break;
                case 700: Console.Write("Seven hundred "); break;
                case 800: Console.Write("Eight hundred "); break;
                case 900: Console.Write("Nine hundred "); break;
                default: Console.Write(""); break;
            }

            if (cnt == 1) n1 = n % 100 - n % 10;
            if (cnt == 2) n1 = n % 10;
        }
        Console.WriteLine();
    }
}

