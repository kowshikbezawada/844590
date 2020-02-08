using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSarrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cars = { "volvo", "benz", "skoda" };
            Console.WriteLine(cars[2]);
            int[] myNum = { 23, 45, 67, 46, 29 };
            Console.WriteLine(myNum[3]);
            string[] employees = new string[5] { "pqr", "plm", "okn", "ijb", "rdg"};
            Console.WriteLine("enter value of i");
            for(int i=0; i<employees.Length; i++)
            {
                Console.WriteLine(employees[i]);
            }
            foreach(string z in employees)
            {
              Console.WriteLine(z);
            }
            
            var result = Average(myNum);
            Console.WriteLine("average of myNum={0}", result);
            Console.ReadKey();
        }
       public static double Average(int[] myNum)
        {
            int total = 0;
            double avg;
            for (int s = 0; s < 5; s++)
                total = total + myNum[s];
            Console.WriteLine("total of myNum={0}", total);
            avg = total / myNum.Length;
            //Console.WriteLine("average of myNum={0}", avg);
            return avg;
        }
    }
}
