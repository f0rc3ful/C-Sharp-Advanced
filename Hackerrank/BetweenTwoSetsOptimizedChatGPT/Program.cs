class Program
{
    static void Main(string[] args)
    {
        List<int> a = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
        List<int> b = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
        int output = BetweenTwoSets(a, b);
        Console.WriteLine(output);
    }
    static int BetweenTwoSets(List<int> a, List<int> b)
    {
        // Local function to calculate the Greatest Common Divisor
        int GCD(int x, int y)
        {
            while (y != 0)
            {
                int temp = y;
                y = x % y;
                x = temp;
            }
            return x;
        }

        // Local function to calculate the Least Common Multiple
        int LCM(int x, int y) => (x / GCD(x, y)) * y;

        // Calculate the LCM of all elements in list a
        int totalLCM = a.Aggregate((result, next) => LCM(result, next));

        // Calculate the GCD of all elements in list b
        int totalGCD = b.Aggregate((result, next) => GCD(result, next));

        // Count how many numbers are there between the LCM of a and the GCD of b
        int count = 0;
        for (int i = totalLCM; i <= totalGCD; i += totalLCM)
        {
            if (totalGCD % i == 0)
            {
                count++;
            }
        }

        return count;
    }
}