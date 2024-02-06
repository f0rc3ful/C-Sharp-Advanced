using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericArrayCreator;

namespace GenericArrayCreator
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(string.Join(" ", ArrayCreator.Create(5, "Pesho"))); ;
        }
    }
}