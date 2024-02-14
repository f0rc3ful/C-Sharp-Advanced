using System.Diagnostics.Metrics;

class Program
{
    static void Main(string[] args)
    {
        int[] a = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        int[] b = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        int leastCommonMultiple = LeastCommonMultiple(a);
        int greatestCommonDivisor = GreatestCommonDivisor(b);
        List<int> multiplesOfLCM = new List<int>();
        for (int i = leastCommonMultiple; i <= greatestCommonDivisor; i++)
        {
            if (i % leastCommonMultiple == 0)
            { 
                multiplesOfLCM.Add(i);
            }
        }

        List<int> factorsOfGCD= new List<int>();
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

        Console.WriteLine(common);
    }

    static int LeastCommonMultiple(int[] a)
    {
        int leastCommonMultiple = a[a.Length-1];
        while (true)
        {
            int counter = 0;
            foreach (int value in a)
            {
                if (leastCommonMultiple % value == 0)
                {
                    counter++;
                }
                if (counter == a.Length)
                {
                    return leastCommonMultiple;
                }   
            }
            leastCommonMultiple++;
        }
    }


    static int GreatestCommonDivisor(int[] b) 
    {
        for (int divisor = b[b.Length - 1]; divisor >= 0; divisor--) // start from greatest value and approach 0
        {
            int counter = 0;
            foreach (int value in b)
            {
                if (value % divisor == 0)
                {
                    counter++;
                }
            }
            if (counter == b.Length)
            {
                return divisor;
            }
        }
        return 0;
    }


}