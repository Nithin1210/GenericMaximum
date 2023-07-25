using GenericFindMaximum;
using System;
namespace FindMaximum
{
     class Program
    {
        public static void Main(string[] args)
        {
            FindMaximum<string> max = new FindMaximum<string>("asdf", "zxcv", "qwerty");
            Console.WriteLine("asdf, zxcv, qwerty");
            Console.WriteLine("MaxString is :" + " "+ max.MaxMethod());

        }
    }

}
