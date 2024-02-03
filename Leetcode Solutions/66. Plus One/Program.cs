using System;

class Program
{
    static void Main(string[] args)
    {
        int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Console.WriteLine(PlusOne(nums));
    }
    static int[] PlusOne(int[] digits)
    {
        
    }
}