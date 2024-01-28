using System;

class Program
{
    static void Main(string[] args)
    {
        // why would we need to assign a method to a variable?
        // only if the method that is assigned to the calculator var, we change the function 
        // i.e. switching between the Sum and Multiply methods
        Func<int, int, int> calculator = Sum;
        Console.WriteLine(calculator(2, 3));
        Console.WriteLine(calculator(3, 4));
        Console.WriteLine(calculator(4, 5));
        Func<string> greet = Greeting;
    }

    static int Multiply(int a, int b)
    {
        return a * b;
    }
    static int Sum(int a, int b)
    {
        return a + b;
    }

    static string Greeting()
    {
        return "Greetings!";
    }
}