using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eventhandler_practice
{
    class Program
    {
        public delegate void deleg();
        public event deleg print;

        public void onprint()
        {
            Console.WriteLine("printing");
        }
        public void myprint()
        {
            Console.WriteLine("printing printing");
        }
        public void show()
        {
            print();
            //return 0;
        }
        static void Main(string[] args)
        {
            Program a = new Program();
            a.print = new deleg(a.onprint);
            a.print += a.myprint;
            a.show();


        }
    }
}
