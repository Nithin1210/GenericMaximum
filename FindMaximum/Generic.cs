using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericFindMaximum
{
    public class Generic<T> where T : IComparable

    {
        public void FindMax(T a, T b, T c)
        {
            if (a.CompareTo(b) >= 0 && a.CompareTo(c) >= 0)
                Console.WriteLine("Maximum is a ");
            if (b.CompareTo(a) >= 0 && b.CompareTo(c) >= 0)
                Console.WriteLine("Maximum is b");
            if (c.CompareTo(a) >= 0 && c.CompareTo(b) >= 0)
                Console.WriteLine("Maximum is c");
        }
    }
}