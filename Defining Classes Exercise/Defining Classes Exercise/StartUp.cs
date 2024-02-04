using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes_Exercise
{
    public class StartUp
    {
        static void Main()
        {
            Person person1 = new Person("Peter", 20);
            Person person2 = new Person("George", 18);
            Console.WriteLine(person1.Name);
            Console.WriteLine(person2.Age);

        }
    }
}
