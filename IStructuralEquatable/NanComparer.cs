using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IStructuralEquatable
{
    internal class NanComparer : IEqualityComparer
    {
        public new bool Equals(object? x, object? y)
        {
            if (x is float)
                return (float)x == (float)y;
            else if (x is double)
                return (double)x == (double)y;
            else
                return EqualityComparer<object>.Default.Equals(x, y);
        }

        public int GetHashCode(object obj)
        {
            return EqualityComparer<object>.Default.GetHashCode(obj);
        }
    }
}
