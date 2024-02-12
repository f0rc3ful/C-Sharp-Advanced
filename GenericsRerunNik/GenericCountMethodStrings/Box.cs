using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCountMethodStrings
{
    public class Box<T>
        where T : IComparable<T>
    {
        public List<T> box;

        public Box()
        {
            box = new List<T>();
        }

        public void Counter(T item)
        {
            int counter = 0;
            foreach (var element in box)
            {
                if (element.CompareTo(item) > 0)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
