using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Keep on entering integers to see if they are even or odd numbers. \nOnce you are done, you can enter \"done\" (case insensitive) and the program will end.");
        string input;
        Func<int, bool> isOdd = x => x % 2 == 0;
        while ((input = Console.ReadLine()).ToLower() != "end")
        {
            if (!int.TryParse(input, out int result))
            {
                Console.WriteLine("Your input is not an integer, please enter a valid input:");
            }
            else if (isOdd(int.Parse(input)))
            {
                Console.WriteLine($"{input} is an even number.");
            }
            else
            {
                Console.WriteLine($"{input} is not an odd number.");
            }
            
        }

    }
}