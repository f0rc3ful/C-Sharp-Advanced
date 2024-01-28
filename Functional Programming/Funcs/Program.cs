using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Func<int, int, int> multiplier = Multiply;
        Func<int, int, int> add = Sum;
        PrintResult(2, 3, Multiply); // call multiplier/Multiply or add/Sum and instantly change funcionality
    }

    static void PrintResult(int a, int b, Func<int, int, int> func)
    {
        int result = func(a, b);
        Console.WriteLine(new string('=', 50));
        Console.WriteLine($"Result: {result}");
        Console.WriteLine(new string('=', 50));
    }

    static int Multiply(int a, int b)
    {
        return a * b;
    }

    static int Sum(int a, int b)
    {
        return a + b;
    }
}