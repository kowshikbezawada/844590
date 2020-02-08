using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ploymorphism
{
    class Program
    {
        static void Main(string[] args)                         //entry point of csharp console application
        {
            Employee emp = new Employee();
            var salary = emp.GetSalary(30, 800);
            Console.WriteLine("salary without incentives: Rs {0}", salary);

            salary = emp.GetSalary(30, 800, 50000);
            Console.WriteLine("salary with incentives: Rs {0}", salary);

            Manager mng = new Manager();
            var ts = mng.GetPerks(30000, 5000);
            Console.WriteLine("salary of manager {0}", ts);

        }
    }
    public class Employee
    {
        public double GetSalary(int nds, int spd)               //this method can be overloaded with different signatures
        {
            double salary = nds * spd;
            return salary;
        }
        public double GetSalary(int nds, float spd, float incent)   //GetSalary method is overloaded
        {
            double salary = (nds * spd) + incent;
            return salary;
        }

        //this method will be overridden in some other base class
        public virtual double GetPerks(float salary, float perks)
        {
            double ts = salary + perks;
            return ts;
        }
    }

    public class Manager : Employee
    {
        public override double GetPerks(float salary, float perks)  //this method can be overriden with same signatures
        {
            return base.GetPerks(salary, perks) * 1.10;            //base keyword refers to the base class

            //double ts = 1.10 * (salry + perks);
            //return ts;
        }
    }
}
