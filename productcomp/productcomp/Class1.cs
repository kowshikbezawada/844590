using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productcomp
{
    public class Class1
    {
        public int ProID { get; set; }
        public string ProName { get; set; }
        public double ProPrice { get; set; }

        public double TotalPrice(double rs, double tax)
        {
            var tprice = rs + tax;
            return tprice;
        }
         public double Discount(double tp)
        {
            var disc = tp - 100;
            return disc;
        }

        public string ShowData()
        {
            return string.Format("ProID = {0},ProName = {1}, ProPrice = {2}", ProID, ProName, ProPrice);
        }

    }
}
