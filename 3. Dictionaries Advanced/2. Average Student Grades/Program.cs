using System;

class Program
{
    static void Main(string[] args)
    {
        int iterations = int.Parse(Console.ReadLine());
        Dictionary<string, List<double>> keyValuePairs= new Dictionary<string, List<double>>();

        for (int i = 0; i < iterations; i++)
        {
            string[] input = Console.ReadLine().Split(" ");
            if (!(keyValuePairs.ContainsKey(input[0])))
            {
                keyValuePairs.Add(input[0], new List<double>());
                keyValuePairs[input[0]].Add(Double.Parse(input[1]));
            }
            else
            {
                keyValuePairs[input[0]].Add(Double.Parse(input[1]));
            }
        }

        foreach (var kvp in keyValuePairs)
        {
            Console.WriteLine($"{kvp.Key} -> {string.Join(" ", kvp.Value.Select(d => d.ToString("F2")))} (avg: {kvp.Value.Average():F2})");
        }
    }
}