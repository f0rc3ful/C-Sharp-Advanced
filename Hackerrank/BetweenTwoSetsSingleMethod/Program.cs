using System.Diagnostics.Metrics;

class Program
{
    static void Main(string[] args)
    {
        List<int> a = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
        List<int> b = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
        int result = BetweenTwoSets(a, b);
        Console.WriteLine(result);
    }

    static int BetweenTwoSets(List<int> a, List<int> b)
    {
        int leastCommonMultiple = a[a.Count - 1];
        bool loop1 = true;
        while (loop1)
        {
            int counter = 0;
            foreach (int value in a)
            {
                if (leastCommonMultiple % value == 0)
                {
                    counter++;
                }
                
                if (counter == a.Count)
                {
                    loop1 = false;
                    break;
                }
            }
            if (loop1 == false)
            {
                break;
            }
            leastCommonMultiple++;
        }

        int greatestCommonDivisor = 0;
        for (int divisor = b[b.Count - 1]; divisor >= 0; divisor--) // start from greatest value and approach 0
        {
            int counter = 0;
            foreach (int value in b)
            {
                if (value % divisor == 0)
                {
                    counter++;
                }
            }
            if (counter == b.Count)
            {
                greatestCommonDivisor = divisor;
                break;
            }
        }

        List<int> multiplesOfLCM = new List<int>(); 
        for (int i = leastCommonMultiple; i <= greatestCommonDivisor; i++)
        {
            if (i % leastCommonMultiple == 0)
            {
                multiplesOfLCM.Add(i);
            }
        }

        List<int> factorsOfGCD = new List<int>(); // dividers
        for (int j = greatestCommonDivisor; j >= leastCommonMultiple; j--)
        {
            if (greatestCommonDivisor % j == 0)
            {
                factorsOfGCD.Add(j);
            }
        }

        int common = 0;
        foreach (int value in factorsOfGCD)
        {
            if (multiplesOfLCM.Contains(value))
            {
                common++;
            }
        }
        return common;
    }
}