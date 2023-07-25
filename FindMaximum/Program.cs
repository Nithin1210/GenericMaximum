using GenericFindMaximum;
using System;
using System.Collections.Generic;

namespace FindMaximum
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("!! Finding the maximum !!");
            Generic<int> max1 = new Generic<int>();
            max1.FindMax(1, 2, 3);

            Generic<float> max2 = new Generic<float>();
            max2.FindMax(2.5f, 9.9f, 11.2f);

            Generic<string> max3 = new Generic<string>();
            max3.FindMax("spiderman", "antman", "batman");
        }
    }
}