using System;
using System.Linq;
using System.Threading.Channels;

class Program
{
    static void Main(string[] args)
    {
        int[] ints = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        int divider = int.Parse(Console.ReadLine());
        Func<int[], int[]> reverser = Reverser;
        ints = reverser(ints);
        Predicate<int> filter = number => !(number % divider == 0);
        ints = ints.Where(number => filter(number)).ToArray();
        Action<int[]> printer = ints => Console.WriteLine(string.Join(" ", ints));
        printer(ints);
    }

    static int[] Reverser(int[] ints)
    {
        int[] reversedInts = new int[ints.Length];
        for (int i = 0; i < ints.Length; i++)
        {
            reversedInts[i] = ints[ints.Length - 1 - i];
        }
        return reversedInts;
    }
}