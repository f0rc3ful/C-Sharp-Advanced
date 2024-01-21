using System;

class Program
{
    static void Main(string[] args)
    {
        decimal iterations = decimal.Parse(Console.ReadLine());
        Dictionary<string, List<decimal>> keyValuePairs= new Dictionary<string, List<decimal>>();

        for (int i = 0; i < iterations; i++)
        {
            string[] input = Console.ReadLine().Split(" ");
            if (!(keyValuePairs.ContainsKey(input[0])))
            {
                keyValuePairs.Add(input[0], new List<decimal>());
                keyValuePairs[input[0]].Add(decimal.Parse(input[1]));
            }
            else
            {
                keyValuePairs[input[0]].Add(decimal.Parse(input[1]));
            }
        }

        foreach (var kvp in keyValuePairs)
        {
            Console.WriteLine($"{kvp.Key} -> {string.Join(" ", kvp.Value.Select(d => d.ToString("F2")))} (avg: {kvp.Value.Average():F2})");
        }
    }
}