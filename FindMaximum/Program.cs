using System;
using System.Collections.Generic;

namespace FindMaximum
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string[] a = { "mn", "qa", "eg", "zx", "as", "qw" };
            Operation<string> operation = new Operation<string>(a);
            Console.WriteLine("Maximum value is : " + operation.FindMax());
        }
    }
}