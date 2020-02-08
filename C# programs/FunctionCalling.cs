using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18thCS
{
    class Program
    {
        static void MyMethod(string fname)
        {
            Console.WriteLine(fname);
        }
        static int MyName(int x, int y)
        {
            return x * y;
        }
        public static string Greetings(int age, string name)
        {
            return string.Format("Congratulations mr {0} on ur {1} birthday", name, age);
        }
        static void Main(string[] args)
        {
            MyMethod("kowshik");
            Console.WriteLine(MyName(2,7));
            var message = Greetings(35, "kowshik");
            Console.WriteLine(message);
            Console.ReadKey();
        }
    }
}
