using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Threadlocks
{
    class Threadlock
    {
        static void Main(string[] args)
        {
            Threadlock obj = new Threadlock();

            Thread T1 = new Thread(obj.display);
            Thread T2 = new Thread(obj.display);
            Thread T3 = new Thread(obj.display);

            T1.Start();
            T2.Start();
            T3.Start();

            Console.ReadKey();
        }
        public void display()
        {
            lock(this)
            {
                Console.Write("[CSharp is an");
                Thread.Sleep(5000);
                Console.WriteLine("object oriented programming]");
            }
        }
    }
}
