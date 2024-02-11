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
            var box = new Box<string>();
            box.Add("matrix");
            box.Add("magicque");
            Console.WriteLine(box.ToString());
        }
    }

    class Box<T>
    {
        private List<T> internalList = new List<T>();

        public void Add(T a)
        {
            internalList.Add(a);
        }

        public T Remove()
        {
            int length = internalList.Count;
            T returned = internalList[length - 1];
            internalList.RemoveAt(length - 1);
            return returned;
        }

        public int Count => internalList.Count;
        
        public override string ToString()
        {
            return $"{typeof(T)}: {string.Join(", ", internalList)}";
        }
    }
}
