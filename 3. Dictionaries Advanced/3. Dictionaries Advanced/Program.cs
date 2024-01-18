using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
     double[] input = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();
     Dictionary<double, int> keyValuePairs= new Dictionary<double, int>();
        foreach (double number in input)
        {
            if (!(keyValuePairs.ContainsKey(number)))
            {
                keyValuePairs.Add(number, 1);
            }
            else
            {
                keyValuePairs[number]++;
            }
        }

        foreach (var kvp in keyValuePairs)
        {
            Console.WriteLine($"{kvp.Key} - {keyValuePairs[kvp.Key]} times");
        }
    }
}