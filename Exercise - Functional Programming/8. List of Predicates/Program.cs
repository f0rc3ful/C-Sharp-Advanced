using System;
using System.Linq;
using System.Threading.Channels;
using System.Xml.Linq;

class Program
{
    static void Main(string[] args)
    {
        int endOfRange = int.Parse(Console.ReadLine());
        int[] ints = IntListGenerator(endOfRange);
        int[] dividers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        Func<int[], int, bool> predicate = (dividers, integer) =>
        {
            bool isDivisible = true;
            foreach (int divider in dividers)
            {
                isDivisible = integer % divider == 0;
            }
            return isDivisible;
        };
        ints = ints.Where(integer => predicate(dividers, integer)).ToArray();
        Action<int[]> printer = array => Console.WriteLine(string.Join(" ", array));
        printer(ints);
    }

    static int[] IntListGenerator(int endOfRange)
    {
        int[] ints = new int[endOfRange];
        for (int i = 1; i <= endOfRange; i++)
        {
            ints[i-1] = i;
        }
        return ints;
    }
}