using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximum
{
    public class Operation
    {
        public void FindMaxFloat(float a, float b, float c)
        {
            if (a >= b && a >= c)
                Console.WriteLine("a is maximum");
            if (b >= c && b >= a)
                Console.WriteLine("b is maximum");
            if (c >= a && c >= b)
                Console.WriteLine("c is maximum");

        }
    }
}
