using System;
class Program
{
    static void Main(string[] args)
    {
        String hello = "Hello";
        String world = "World";
        object concat = hello + world;
        String assing = Convert.ToString(concat);
        Console.WriteLine(assing);
    }
}

