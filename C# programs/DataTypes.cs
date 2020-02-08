using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rough
{
    class Program
    {
        static void Main(string[] args)
        {
            byte bb = 255;

            short s = 99;

            int n = 95;

            long l = 5678444790;

            float f = 10.99f;

            double d = 30.99;

            decimal m = 999.99m;



            Console.WriteLine("values of {0} {1} {2} {3} {4} {5} {6} ", bb, s, n, l, f, d, m);

            DateTime dd = DateTime.Now;

            Console.WriteLine("current time is {0}", dd);

            Console.WriteLine("the current short date {0}", dd.ToShortDateString());

            Console.WriteLine("the current long date {0}", dd.ToLongDateString());

            Console.WriteLine("the current time is {0}", dd.ToShortTimeString());

            Console.WriteLine("the current long {0}", dd.ToLongTimeString());

            int a, b;

            a = 50; b = 50;

            Add(a, b);

            Multiply(a, b);

            Console.WriteLine("the multiply of two numbers is {0}", Multiply(a, b));
            Console.ReadKey();

        }
        public static void Add(int a, int b)
        {
            double d = a + b;
            Console.WriteLine("the sum of two numbers is {0}", d);
        }
        public static double Multiply(int a, int b)
        {
            double d = a * b;
            return d;
        }
    }
}
