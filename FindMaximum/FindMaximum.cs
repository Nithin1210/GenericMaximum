using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximum
{
    public class Operation
    {
        public void FindMaxInteger(int a, int b, int c)
        {
            if (a >= b && a >= c)
                Console.WriteLine("a is maximum");
            if (b >= c && b >= a)
                Console.WriteLine("b is maximum");
            if (c >= a && c >= b)
                Console.WriteLine("c is maximum");
        }
        public void FindMaxFloat(float a , float b , float c)
        {
            if (a >= b && a >= c)
                Console.WriteLine("a is maximum");
            if (b >= c && b >= a)
                Console.WriteLine("b is maximum");
            if (c >= a && c >= b)
                Console.WriteLine("c is maximum");
        }
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