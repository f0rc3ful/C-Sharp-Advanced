using System;
using System.Linq;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        int[] range = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        string condition = Console.ReadLine();
        List<int> numbers = new List<int>();
        Func<int[], List<int>> listFiller = Filler;
        numbers = Filler(range);
        Func<int, bool> function = x => x % 2 == 0;
        if (condition == "odd")
        {
            function = x => x % 2 == 1;
        }
        numbers = numbers.Where(function).ToList();
        Action<List<int>> printer = list => Console.WriteLine(string.Join(" ", numbers));
        printer(numbers);
    }

    static List<int> Filler(int[] range)
    {
        List<int> numbers = new List<int>();
        for (int i = range[0]; i <= range[1]; i++)
        { 
            numbers.Add(i);
        }
        return numbers;
    }
}