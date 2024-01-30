using System;
using System.Linq;
using System.Threading.Channels;
using System.Xml.Linq;

class Program
{
    static void Main(string[] args)
    {
        int maxLength = int.Parse(Console.ReadLine());
        string[] names = Console.ReadLine().Split(" ");
        Predicate<string> predicate = name => name.Length <= maxLength;
        names = names.Where(name => predicate(name)).ToArray();
        Action<string[]> printer = name => Console.WriteLine(string.Join("\n", name));
        printer(names);
    }
}