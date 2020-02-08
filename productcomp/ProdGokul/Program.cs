using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using productcomp;

namespace ProdGokul
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 pc = new Class1() { ProID = 010, ProName = "ProteinPowder", ProPrice= 3000 };
            //Console.WriteLine("ProID: {0}, ProName: {1}, ProPrice: {2}", ProID, ProID, ProPrice);
            var data = pc.ShowData();
            Console.WriteLine(data);

            var PRICE = pc.TotalPrice(2850, 150);
            var DISCOUNT = pc.Discount(PRICE);


            Console.WriteLine("Price: {0}, discount: {1}", PRICE, DISCOUNT);

            Console.ReadKey();
        }
    }
}
