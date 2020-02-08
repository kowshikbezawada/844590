using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datatype
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 50;
            if (a > 22)
                Console.WriteLine("Good Morning");
            else if (a < 35)
                Console.WriteLine("Good Evening");
            else
                Console.WriteLine("good night");

            int b =5;
            switch(b)
            {
                case 1:Console.WriteLine("hello, how r u?");
                    break;
                case 2:Console.WriteLine("hii, i am good");
                    break;
                case 3:Console.WriteLine("hope, u r doing well");
                    break;
                default:Console.WriteLine("It seems u r not doing well");
                    break;

            }

            //loop structures

            Console.WriteLine("enter a number to display its tables");
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
                Console.WriteLine("{0} * {1} = {2}", number, i, number * i);

            int fn;
            int fact = 1;

            Console.WriteLine("enter a number to find its factorial");
            fn = int.Parse(Console.ReadLine());
            for (int i = 1; i <= fn; i++)
                fact = fact * i;
            Console.WriteLine("the factorial of {0} is {1}", fn, fact);

           

            Console.ReadKey();

        }
    }
}
