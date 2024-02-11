using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericArrCreator
{
    class Program
    {
        static void Main()
        {
            string[] array = ArrayCreator<string>.Creator(7,"Kolio");
            Console.WriteLine(string.Join(", ", array));
        }
    }
}
