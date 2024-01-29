using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Func<string, string, string> evensOrodds = EvensOrOdds;
        string range = Console.ReadLine();
        string format = Console.ReadLine();
        string output = evensOrodds(range, format);
        Console.WriteLine(output);
    }

    static string EvensOrOdds(string input, string format)
    {
        List<int> numbers = new List<int>();
        int[] range = input.Split(" ").Select(int.Parse).ToArray();
        int startOfRange = range[0];
        int endOfRange = range[1];
        for (int i = startOfRange; i <= endOfRange; i++)
        {
            if (format == "odd")
            {
                if (i % 2 == 1)
                {
                    numbers.Add(i);
                }
            }
            else if (format == "even")
            {
                if (i % 2 == 0)
                {
                    numbers.Add(i);
                }
            }
        }
        string output = string.Join(" ", numbers);
        return output;
    }
}