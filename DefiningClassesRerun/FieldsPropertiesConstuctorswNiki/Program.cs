using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldsPropertiesConstructorswNiki
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("zara", -1);
            Console.WriteLine(person1.Name);
            Console.WriteLine(person1.Age);
        }
    }
}
