using System;
using System.Linq;

class Program
{
    //· "add" -> add 1 to each number

    //· "multiply" -> multiply each number by 2

    //· "subtract" -> subtract 1 from each number

    //· "print" -> print the collection

    //· "end" -> ends the input
    static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        Func<int, int> manipulator = x => x;
        Action<int[]> printer = numbers => Console.WriteLine(string.Join(" ", numbers));
        string command;
        while ((command = Console.ReadLine()) != "end")
        {
            if (command == "add")
            {
                manipulator = x => x + 1;
            }
            else if (command == "subtract")
            {
                manipulator = x => x - 1;
            }
            else if (command == "multiply")
            {
                manipulator = x => x * 2;
            }
            else if (command == "print")
            {
                printer(numbers);
            }
            numbers = numbers.Select(manipulator).ToArray();
        }
    }
}