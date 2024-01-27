using System;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        List<double> doubles = AddVAT(input);
        foreach (var digit in doubles)
        {
            Console.WriteLine($"{digit:F2}");
        }
    }

    static List<double> AddVAT(string input)
    {
        return input
            .Split(",")
            .Select(double.Parse)
            .Select(x => x * 1.2)
            .ToList();
    }
}