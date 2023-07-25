using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericFindMaximum
{
    public class FindMaximum<T> where T : IComparable
    {
        public T a, b, c;
        public FindMaximum(T a, T b, T c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public static T MaxValue(T a, T b, T c)
        {
            if (a.CompareTo(b) >= 0 && a.CompareTo(c) >= 0 )
            {
                return a;
            }
            if (b.CompareTo(a) >= 0 && b.CompareTo(c) >= 0 )
        
            {
                return b;
            }
            if (c.CompareTo(a) >= 0 && b.CompareTo(b) >= 0)                
            {
                return c;
            }
            return default;
        }
        public T MaxMethod()
        {
            T max = MaxValue(this.a, this.b, this.c);
            return max;

        }
    }
}
