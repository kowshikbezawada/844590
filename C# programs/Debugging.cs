using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace debugging
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            a = 8; b = 7;
            Multiply(a, b);

            for(int i=1; i<=5; i++)
            {
                var result = 60 + i;
                var ultimate = 2645 + result;
                Console.WriteLine("result = {0}", ultimate);
            }
        }
        public static double Multiply(int a, int b)
        {
            var pro = a * b;
            return pro;
        }
    }
}
