
using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        HashSet<string> guests = new HashSet<string>();

        string input1;
        while ((input1 = Console.ReadLine()) != "PARTY")
        { 
            guests.Add(input1);
        }

        string input2;
        while ((input2 = Console.ReadLine()) != "END")
        {
            guests.Remove(input2);
        }

        Console.WriteLine(guests.Count);
        guests = guests.OrderBy(x => x).ToHashSet();
        if (guests.Count > 0)
        {
            Console.WriteLine(string.Join("\n", guests));
        }
    }
}
