using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> list = StringToAscendingIntList(Console.ReadLine());
        Console.WriteLine(list.Count());
        Console.WriteLine(list.Sum());
    }
    static List<int> StringToAscendingIntList(string input)
    {
        return input
            .Split(", ")
            .Select(int.Parse)
            .ToList();
    }
}