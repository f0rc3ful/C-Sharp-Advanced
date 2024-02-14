class Program
{
    static void Main(string[] args)
    {
        List<int> a = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
        List<int> b = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
        int output = BetweenTwoSets(a, b);
        Console.WriteLine(output);
    }
    static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    static int LCM(int a, int b)
    {
        return (a / GCD(a, b)) * b;
    }

    static int BetweenTwoSets(List<int> a, List<int> b)
    {
        int lcm = a.Aggregate((current, next) => LCM(current, next));
        int gcd = b.Aggregate((current, next) => GCD(current, next));

        int count = 0;
        for (int i = lcm, step = lcm; i <= gcd; i += step)
        {
            if (gcd % i == 0) count++;
        }

        return count;
    }
}