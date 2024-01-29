using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Func<string, int> customMinFunc = CustomMinFunction;
        int output = customMinFunc(Console.ReadLine());
        Console.WriteLine(output);
    }

    static int CustomMinFunction(string input)
    {
        int[] ints = input.Split(" ").Select(int.Parse).ToArray();
        int min = int.MaxValue;
        for (int i = 0; i < ints.Length; i++)
        {
            if (ints[i] < min)
            { 
                min = ints[i];
            }
        }
        return min;
    }
}