using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericBoxOfString
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Box<string> box = new Box<string>();
            for (int i = 0; i < n; i++)
            {
                box.Add(Console.ReadLine());
            }
            Console.WriteLine(box);
        }
    }
}