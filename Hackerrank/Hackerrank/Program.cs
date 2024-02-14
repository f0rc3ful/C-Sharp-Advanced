class Program
{
    static void Main(string[] args)
    {
        int[] a = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        //int[] b = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        int leastCommonMultiple = LeastCommonMultiple(a);
        //int greatestCommonDivisor = GreatestCommonDivisor(b);
        Console.WriteLine(leastCommonMultiple);
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