using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximum
{
    public class Operation
    {
        public void FindMaxString(string a, string b, string c)
        {
            if (a.CompareTo(b) >= 0 && a.CompareTo(c) >= 0)
                Console.WriteLine("a in maximum");
            if (b.CompareTo(a) >= 0 && b.CompareTo(c) >= 0)
                Console.WriteLine("b in maximum");
            if (c.CompareTo(b) >= 0 && c.CompareTo(a) >= 0)
                Console.WriteLine("c in maximum");
        }
    }
}
