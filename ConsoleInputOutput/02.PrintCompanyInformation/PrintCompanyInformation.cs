using System;
class PrintCompanyInformation
{
    static void Main(string[] args)
    {
        Console.Write("Company name : ");
        string cName = Console.ReadLine();
        Console.Write("Company address : ");
        string addres = Console.ReadLine();
        Console.Write("Phone number : ");
        string cNumber = Console.ReadLine();
        Console.Write("Fax number : ");
        string cFax = Console.ReadLine();
        Console.Write("Web site : ");
        string web = Console.ReadLine();
        Console.Write("Manager first name : ");
        string mFirstName = Console.ReadLine();
        Console.Write("Manager last name : ");
        string mLastName = Console.ReadLine();
        Console.Write("Manager age : ");
        string mAge = Console.ReadLine();
        Console.Write("Manager phone : ");
        string mPhone = Console.ReadLine();
        Console.WriteLine("{0}\r\nAddress: {1}\r\nTel. {2}\r\nFax: {3}\r\nWeb site: {4}\r\nMannager : {5} {6} (age: {7}, tel.{8})"
            , cName, addres, cNumber,cFax,web,mFirstName,mLastName,mAge,mPhone);
        

        
    }
}

