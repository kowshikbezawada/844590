using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eventhandler
{
    class Program
    {
        public delegate int deleg();
        public event deleg print;
        public void OnPrint()
        {
            Console.WriteLine("It printed");
        }
        public void show()
        {
            print();
        }
        static void Main(string[] args)
        {
            Program a = new Program();
            a.print = new deleg(a.OnPrint);
            a.show();
            Console.ReadKey();
        }
    }
}