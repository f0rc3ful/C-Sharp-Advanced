using System;
using System.Linq;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args) 
    {
        string name = "Adam";
        Action<string> printeur = PrintString;
        PrintString(name);
        var list = new List<int> { 1,2,3,4,5 };
        var newList = list.Where(x => x % 2 == 0).ToList(); // the Where method utilizes an anonymous function
        Console.WriteLine(string.Join(", ", newList));
    }

    static void PrintString(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }

    static bool IsEven1(int a) => a % 2 == 0;

    static bool IsEven2(int a)
    {
        return a % 2 == 0;
    }

    static bool IsEven3(int a)
    {
        if (a % 2 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}