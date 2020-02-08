using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enums
{
    class Program
    {
        enum Department
        {

            Physics = 1,
            Chemistry,
            Maths,
            Biology
        };
        enum Color
        {
            Red = 100,
            Green,
            Blue
        };
        static void Main(string[] args)
        {
            Console.WriteLine("Department id of Physics: {0}", (int)Department.Physics);
            Console.WriteLine("Department id of Chemistry: {0}", (int)Department.Chemistry);
            Console.WriteLine("Department id of Maths: {0}", (int)Department.Maths);
            Console.WriteLine("Department id of Biology: {0}", (int)Department.Biology);

            Console.WriteLine("The color indicates: {0}", (int)Color.Red);
            Console.WriteLine("The color indicates: {0}", (int)Color.Green);
            Console.WriteLine("The color indicates: {0}", (int)Color.Blue);

            Console.ReadKey();
        }
    }
}
