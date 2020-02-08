using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delex
{
   
    class Program
    {
        public delegate void operations(int a, int b);
        static void Main(string[] args)
        {
            operations execute = new operations(Add);
            execute += Difference;
            execute += Product;
            execute += Quotient;
            execute.Invoke(80, 20);

        }

         public static void Add(int a, int b)
    {
        int add = a + b;
        Console.WriteLine("the sum of {0} and {1} = {2}",a,b,add);
    }
    public static void Difference(int a, int b)
    {
        int diff = a - b;
        Console.WriteLine("the difference of {0} and {1} = {2}",a,b,diff);
    }
    public static void Product(int a, int b)
    {
        int pro = a * b;
        Console.WriteLine("the difference of {0} and {1} = {2}",a,b,pro);
    }
    public static void Quotient(int a, int b)
    {
        int quo = a / b;
        Console.WriteLine("the difference of {0} and {1} = {2}",a,b,quo);
    }
    }
   
}
