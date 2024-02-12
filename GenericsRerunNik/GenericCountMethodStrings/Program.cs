using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCountMethodStrings
{
    class Program
    {
        static void Main()
        {
            Box<string> list = new Box<string>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                list.box.Add(Console.ReadLine());
            }

            string item = Console.ReadLine();

            list.Counter(item);
        }

        


    }
}
