using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            SBAccount objSB = new SBAccount();
            CCAccount objCC = new CCAccount();

            double siSB = objSB.GetSimpleInterest(95000.00, 5, 8);
            double tamt = objSB.GetTotalAmount(50000.00, siSB);

            Console.WriteLine("Simple Interest(savings account): Rs {0}", siSB);
            Console.WriteLine("Total Amount: RS {0}", tamt);

            double siCC = objCC.GetSimpleInterest(95000.00, 5, 8);
            tamt = objCC.GetTotalAmount(50000.00, siCC);

            Console.WriteLine("Simple Interest(current account): Rs {0}", siCC);
            Console.WriteLine("Total Amount: Rs {0}", tamt);

            objSB.Show();
        }
    }
    public abstract class Banking
    {
        public abstract double GetSimpleInterest(double pr, int d, short rt);
        public abstract double GetTotalAmount(double si, double bal);

        public void Show()
        {
            Console.WriteLine("This is a concrete method defined within an abstract class");
        }
    }
    public class SBAccount : Banking
    {
        public override double GetSimpleInterest(double pr, int d, short rt)
        {
            double si =  (pr * d * rt) / 100;
            return si;
        }

        public override double GetTotalAmount(double si, double bal)
        {
            double tamount = bal + si;
            return tamount;
        }
    }

    public class CCAccount : Banking
    {
        public override double GetSimpleInterest(double pr, int td, short rt)
        {
            double si = 0.25 * ((pr * td * rt) / 100);
            return si;
        }
        public override double GetTotalAmount(double bal, double si)
        {
            double tamount = bal + si;
            return tamount;
        }

    }
}
   

