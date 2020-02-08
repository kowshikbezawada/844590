using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace threadpriority
{
    class Program
    {
        public static long count1, count2;
        static void Main(string[] args)
        {
            Thread t1 = new Thread(Inccount1);
            Thread t2 = new Thread(Inccount2);

            Console.WriteLine("Main thread is started");

            t1.Start();
            t2.Start();

            t1.Priority = System.Threading.ThreadPriority.Lowest;
            t2.Priority = System.Threading.ThreadPriority.Highest;

            Thread.Sleep(5000);

            t1.Abort();
            t2.Abort();

            t1.Join();
            t2.Join();

            Console.WriteLine("count1 : {0}", count1);
            Console.WriteLine("count2 : {0}", count2);

            Console.WriteLine("The Main thread is exited");
        }

        public static void Inccount1()
        {
            while(true)
            {
                count1 += 1;
            }
            Console.WriteLine("count1 : {0}", count1);
        }
        public static void Inccount2()
        {
            while(true)
            {
                count2 += 1;
            }
            Console.WriteLine("count2 : {0}", count2);
        }
    }
}
