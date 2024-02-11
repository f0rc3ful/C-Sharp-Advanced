using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseBoxOfString
{
    class Program
    {
        static void Main()
        {
            int lines = int.Parse(Console.ReadLine());
            Box<string> box = new Box<string>();
            for (int i = 0; i < lines; i++)
            {
                box.values.Add(Console.ReadLine());
            }
            Console.WriteLine(box.ToString());
        }
    }
}
