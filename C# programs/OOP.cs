using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_concepts
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee(123, "kowshik", 2, "HR");
            Employee emp2 = new Employee(456, "kartheek", 3, "Technical");
            Employee emp3 = new Employee(789, "kiran");
            emp1.ShowData();
            emp2.ShowData();
            emp3.ShowData();
            Product prd = new Product() { ProductID = 1, Productname = "Samsung Note 11", Price = 78000, Quantity = "2" };
            prd.ShowData();
            Customer cst1 = new Customer() { CustomerID = 1, Customername = "Gokul", Vehicle = "Yamaha R15", Model = "2020" };
            Customer cst2 = new Customer() { CustomerID = 2, Customername = "Praveen", Vehicle = "Honda CBR", Model = "2020" };
            cst1.ShowData();
            cst2.ShowData();
        }
        class Employee
        {
            int empid;
            string empname;
            short depid;
            string depname;

            public Employee(int id, string ename, short did, string dname)
            {
                empid = id;
                empname = ename;
                depid = did;
                depname = dname;
            }
            public Employee(int id, string ename)
            {
                empid = id;
                empname = ename;
            }
            public void ShowData()
            {
                Console.WriteLine("empid={0},empname={1}, depid={2},depname={3}", empid, empname, depid, depname);
            }

        }
        //Access Specifiers
        //private, protected, public, internal, protected internal
        //private - can only be accessed within the class wherew it is derived
        //protected - can only be accesed within both its base and derived class
        //public - can be accessed anywhere both within or outside of that class or assembly
        //internal - can be accessed only within the current assembly of where that class is defined
        //protected internal - can be accessed within the assembly and only within the derived class of that assembly

        public class Product
        {
            int pid;
            //defining properties for the class
            public int ProductID
            {
                get { return pid; }
                set { pid = value; }
            }
            //Automatic properties, compiler does the implementation here
            public string Productname
            {
                get;
                set;
            }
            public double Price
            {
                get;
                set;
            }
            public string Quantity
            {
                get;
                set;
            }
            public void ShowData()
            {
                Console.WriteLine("productid = {0}, productname = {1}, price = {2}, quantity = {3}",  pid, Productname, Price, Quantity);
            }

        }
        public class Customer
        {
            int cid;

            //defining properties for the class
            public int CustomerID
            {
                get { return cid; }
                set { cid = value; }
            }
            //Automatic properties, compiler does the implementation here
            public string Customername
            {
                get;
                set;
            }
            public string Vehicle
            {
                get;
                set;
            }
            public string Model
            {
                get;
                set;
            }
            public void ShowData()
            {
                Console.WriteLine("Customerid = {0}, customername = {1}, vehicle = {2}, model = {3}", cid, Customername, Vehicle, Model);
            }

        }
    }

}
