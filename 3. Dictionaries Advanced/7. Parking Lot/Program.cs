
using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string input;
        HashSet<string> parkingLot = new HashSet<string>();
        while ((input = Console.ReadLine()) != "END") 
        {
            string[] command = input.Split(", ");
            if (command[0] == "IN")
            {
                parkingLot.Add(command[1]);
            }
            else if (command[0] == "OUT")
            {
                parkingLot.Remove(command[1]);
            }
        }

        if (parkingLot.Count == 0)
        {
            Console.WriteLine("Parking Lot is Empty");
        }
        else
        {
            Console.WriteLine(string.Join("\n", parkingLot));
        }

    }
}


//CA9999TT

//CA2844AA
//CA9876HH
//CA2822UU