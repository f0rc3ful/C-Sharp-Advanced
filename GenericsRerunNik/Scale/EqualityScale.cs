using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scale
{
    public class EqualityScale<T>
        where T : class
    {
        private T left;
        private T right;

        public EqualityScale(T left, T right)
        {
            this.left = left; // "this" highlights that we are ref. the item in the class, not the parameter in the ctor
            this.right = right;
        }

        public bool AreEqual(T left, T right) 
        {
            return left == right;
        }
    }
}
