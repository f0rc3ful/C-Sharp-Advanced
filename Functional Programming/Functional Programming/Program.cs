using System;

class Program
{
    static void Main(string[] args)
    {
        Func<int, int, int> calculator = Multiplicator;
        Console.WriteLine(calculator(2, 3));
        Console.WriteLine(calculator(3, 4));
        Console.WriteLine(calculator(4, 5));
    }

    static int Multiplicator(int a, int b)
    {
        return a * b;
    }
    static int Sum(int a, int b)
    {
        return a + b;
    }
}