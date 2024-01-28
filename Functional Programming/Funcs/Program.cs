using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Func<int, int, int> func = Multiply;
        Console.WriteLine("Please enter 2 integers that you want to manipulate, separated by a comma:");
        int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
        PrintResult(input[0], input[1], func);
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
}