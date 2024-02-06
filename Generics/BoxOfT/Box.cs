using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxOfT
{
    public class Box<T>
    {
        public List<T> box;

        public Box()
        { 
            box = new List<T>();
        }
        public void Add(T element)
        {
            box.Add(element);
        }
        public T Remove()
        {
            int length = box.Count;
            T last = box.Last();
            box.RemoveAt(length - 1);
            return last;
        }
        public int Count
        {
            get
            {
                return box.Count();
            }
        }
    }
}
