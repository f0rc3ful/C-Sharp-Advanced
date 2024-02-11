using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericSwapMethodStrings
{
    public class CustomList<T>
    {
        public List<T> list;

        public CustomList()
        {
            this.list = new List<T>();
        }
    }
}
