using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ployexm
{
    class Program
    {
        static void Main(string[] args)
        {
            

            College c = new College();
            var tf = c.Fees(85000, 12000);
            Console.WriteLine("Total fees for dayscoler = {0}", tf);

            tf = c.Fees(85000, 12000, 70000);
            Console.WriteLine("Total Fees for Hostellee = {0}", tf);

            HOD hsal = new HOD();
            var hdsal = hsal.Prfsalary(25000);
            Console.WriteLine("The salary of HOD = {0}", hdsal);

        }
    }
   
    public class College
    {
        public double Fees(double clgfee, double Exmfee)
        {
            double tlfee = clgfee + Exmfee;
            return tlfee;
        }

        public double Fees(double clgfee, double Exmfee, double hstlfee)
        {
            double tlfee = clgfee + Exmfee + hstlfee;
            return tlfee;
        }

        public virtual double Prfsalary(double salary)
        {
            return salary;
        }
    }

    public class HOD : College
    {
        public override double Prfsalary(double salary)
        {
            return base.Prfsalary(salary) + 10000;
        }
    }
}

      

