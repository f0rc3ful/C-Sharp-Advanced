using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericScale
{
    class Program
    {
        static void Main()
        {
            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            EqualityScale<int> scale = new EqualityScale<int>(input[0], input[1]);
            Console.WriteLine(scale.AreEqual());
        }
    }
}