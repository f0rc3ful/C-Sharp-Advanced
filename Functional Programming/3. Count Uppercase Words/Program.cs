using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(string.Join("\n", FilterUpperCaseWords(Console.ReadLine())));
    }
    static string[] FilterUpperCaseWords(string input)
    {
        return input
            .Split(" ")
            .Where(s => !string.IsNullOrEmpty(s) && Char.IsUpper(s[0]))
            .ToArray();
    }
}