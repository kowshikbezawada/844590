using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates_and_events
{
    class Program
    {
        public delegate double SalDelegate(int ds, float sd);

        static void Main(string[] args)
        {
            SalDelegate deleg = new SalDelegate(GetSalary);
            var salary = deleg.Invoke(30, 800);
            Console.WriteLine("salary = {0}", salary);
            deleg += GetIncentive;
            var incent = deleg.Invoke(30, 800);
            Console.WriteLine("Incentive = {0}", incent);

        }


        public static double GetSalary(int nds, float spd)
        {
            var salary = (nds * spd);
            return salary;
        }
        public static double GetIncentive(int nds, float spd)
        {
            var incent = 0.1 * (nds * spd);
            return incent;
        }
    }
}
