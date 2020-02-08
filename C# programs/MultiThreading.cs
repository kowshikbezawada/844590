using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace multithreading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main thread is started");

            Thread t = Thread.CurrentThread;
            t.Name = "Main Thread";
            Console.WriteLine("{0} is running now with ID: {1}", t.Name, t.ManagedThreadId);

            //Method1();
            //Method2();
            //Method3();

            Thread T1 = new Thread(new ThreadStart(Method1));
            Thread T2 = new Thread(Method2);  //method2 is implicitly called by the threadstart delegate
            Thread T3 = new Thread(Method3);

            T1.Start();
            T2.Start();
            T3.Start();

            Thread Tp = new Thread(new ParameterizedThreadStart(Test));
            Tp.Start(50);

            T1.Join(); T2.Join(); T3.Join(); Tp.Join();  //join method is responsible for preventing the main thread to exit from the fray 
                                                         //the fray unless all the child threads have completed with their tasks
            Console.WriteLine("Main thread is exited");

        }
        public static void Method1()
        {
            Console.WriteLine("Thread1 is started");
            for (int i = 1; i <= 50; i++)
                Console.WriteLine("Method1: {0}", i);
            Console.WriteLine("Thread1 is exited");
        }
        public static void Method2()
        {
            Console.WriteLine("Thread2 is started");
            for (int i = 1; i <= 50; i++)
            {
                if (i == 25)
                {
                    Thread.Sleep(5000);
                }
                Console.WriteLine("Method2: {0}", i);
            }
            Console.WriteLine("Thread2 is exited");
        }
        public static void Method3()
        {
            Console.WriteLine("Thread3 is started");
            for (int i = 1; i <= 50; i++)
                Console.WriteLine("Method3: {0}", i);
            Console.WriteLine("Thread3 is exited");

        }
        public static void Test(object max)
        {
            int j = Convert.ToInt32(max);
            for (int i = 1; i < j; i++)
            {
                Console.WriteLine("Test: {0}", i);
            }
        }

    }
}
