using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericArrCreator
{
    public class ArrayCreator<T>
    {
        public static T[] Creator(int length, T item)
        {
            T[] array = new T[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = item;
            }

            return array;
        }
    }
}
