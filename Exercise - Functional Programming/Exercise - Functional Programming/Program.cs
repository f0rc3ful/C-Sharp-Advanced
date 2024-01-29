using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Action<string> printer = Printer;
        printer(Console.ReadLine());
    }

    static void Printer(string input)
    {
        string[] strings = input.Split(" ");
        foreach (string s in strings)
        {
            Console.WriteLine(s);
        }
    }
}