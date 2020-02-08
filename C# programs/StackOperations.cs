using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack_operations
{
    class Program
    {
        static void Main(string[] args)
        {

            Stack<float> fnumbers = new Stack<float>();
            fnumbers.Push(10.90f);
            fnumbers.Push(12.90f);
            fnumbers.Push(13.90f);
            fnumbers.Push(15.90f);
            Console.WriteLine("\nbefore calling the pop method\n");

            foreach (var fn in fnumbers)
                Console.WriteLine(fn);

            fnumbers.Pop();                                     //this method removes the object at the top
            Console.WriteLine("\nafter calling the pop method\n");
            foreach (var fn in fnumbers)
                Console.WriteLine(fn);

            Queue<double> qnumbers = new Queue<double>();
            qnumbers.Enqueue(10.98);
            qnumbers.Enqueue(13.85);
            qnumbers.Enqueue(12.69);
            qnumbers.Enqueue(15.98);

            Console.WriteLine("\nbefore calling the dequeue method\n");
            foreach (var qn in qnumbers)
                Console.WriteLine(qn);

            qnumbers.Dequeue();                                 //this method removes the object at the top
            Console.WriteLine("\nafter calling the dequeue method\n");
            foreach (var qn in qnumbers)
                Console.WriteLine(qn);

            int a, b;
            a = 50; b = 30;

            Console.WriteLine("before swap: a = {0}, b = {1}", a, b);
            Swap<int>(ref a, ref b);
            Console.WriteLine("after swap: a = {0}, b = {1}", a, b);

            string s1, s2;
            s1 = "hello";
            s2 = "world";

            Console.WriteLine("beore swap: s1 = {0}, s2 = {1}", s1, s2);
            Swap<string>(ref s1, ref s2);
            Console.WriteLine("beore swap: s1 = {0}, s2 = {1}", s1, s2);

        }

        public static void Swap<T>(ref T a, ref T b)            //Generic method used to swap diferent types
        {
            T c;
            c = a;
            a = b;
            b = c;
        }
    }
}
