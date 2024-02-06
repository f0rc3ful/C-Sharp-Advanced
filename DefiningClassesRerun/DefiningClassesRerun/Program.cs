using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Counter(n);
    }

    static void Counter(int n)
    {
        ////if (n == 0)
        ////{
        ////    return;
        ////}
        Console.WriteLine(n);
        Counter(n - 1);
    }
}