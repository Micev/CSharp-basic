using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.QuotesInString
{
    class Program
    {
        static void Main(string[] args)
        {
            String sentence1 = "The \"use\" of quotation causes difficulties.";
            String sentence2 = @"The ""use"" of quotation causes difficulties.";
            Console.WriteLine(sentence1 +"\n"+sentence2);
        }
    }
}
