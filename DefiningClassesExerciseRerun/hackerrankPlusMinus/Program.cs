using System.Runtime.CompilerServices;
using System.Text;

class Program
{
    static void Main()
    {
        List<int> ints= Console.ReadLine().Split(",").Select(int.Parse).ToList();
        miniMaxSum(ints);
    }

    public static void miniMaxSum(List<int> ints)
    {
        int minSum = int.MaxValue;
        int maxSum = int.MinValue;
        for (int i = 0; i < ints.Count; i++)
        {
            int sum = 0;
            int removed = ints[0];
            ints.RemoveAt(0);
            foreach (int number in ints)
            { 
                sum += number;
            }
            if (sum > maxSum)
            {
                maxSum = sum;
            }
            else if (sum < minSum)
            {
                minSum = sum;
            }
            ints.Add(removed);
        }
        Console.WriteLine($"{minSum} {maxSum}");
    }
}