using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace linqdatabase
{
    class Program
    {
        SqlConnection sqlcon;
        SqlCommand sqlcmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataSet ds;
        string constring, qrystring ,country;
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Show();
            Console.ReadKey();
             
        }
        public void Show()
        {
            constring = "data source=BLT10137\\SQLEXPRESS2014;Initial Catalog=Northwind;Integrated Security=True;";
            sqlcon = new SqlConnection(constring);
            sqlcon.Open();
            Console.WriteLine("enter the Country's name:");
            country = Console.ReadLine();
            qrystring = "Select ContactName from Customers where Country ='" + country + "'";
            sqlcmd = new SqlCommand(qrystring, sqlcon);
            da = new SqlDataAdapter(sqlcmd);
            ds = new DataSet();
            da.Fill(ds, "ContactName");
            DataTable dt = ds.Tables["ContactName"];
            var customers = from customer in dt.AsEnumerable()
                            select new
                            {
                                contName = customer["ContactName"]
                            };
            foreach(var i in customers)
            {
                    Console.WriteLine("{0}", i.contName);
            
            }
            sqlcon.Close();
        }
    }
}
