using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList items = new ArrayList(100);
            //items.Add({ "Hello World"});
            
            Dictionary<int, String> fruits = new Dictionary<int, string>();
            fruits.Add(1, "apple");
            fruits.Add(2, "orange");
            fruits.Add(3, "banana");
            fruits.Add(4, "pineapple");
            //adding employee objects to the list collection

            List<Employee> Employee = new List<Employee>();

            Employee.Add(new Employee() { id = 111, name = "gokul", salary = 25000 });
            Employee.Add(new Employee() { id = 112, name = "vimal", salary = 28000 });
            Employee.Add(new Employee() { id = 113, name = "milan", salary = 35000 });
            Employee.Add(new Employee() { id = 114, name = "mohan", salary = 38000 });

            foreach(var emp in Employee)
            {
                Console.WriteLine("Id = {0}, Name = {1}, Salary = {2}", emp.id, emp.name, emp.salary);
            }

            //stack and queue data structures

            //stack is Last In First Out 




            foreach (KeyValuePair<int, string> kv in fruits)
            {
                Console.WriteLine("key -> {0}, value -> {1}", kv.Key, kv.Value);

            }

            //deletng an intem from the collection

            fruits.Remove(4);
            fruits.Add(4, "custerdapple");

            foreach(KeyValuePair<int, string> kv in fruits)
            {
                Console.WriteLine("key -> {0}, value -> {1}", kv.Key, kv.Value);
            }

            SortedDictionary<int, string> gadgets = new SortedDictionary<int, string>();

            gadgets.Add(5, "kowshik");
            gadgets.Add(2, "praveen");
            gadgets.Add(4, "kartheek");
            gadgets.Add(1, "kiran");
            gadgets.Add(3, "kishore");

            foreach(KeyValuePair<int, string> kv in gadgets)
            {
                Console.WriteLine("key -> {0}, value -> {1}", kv.Key, kv.Value);
            }
        }
    }
     class Employee
    {
        public int id
        {
            get;
            set;
        }
        public string name
        {
            get;
            set;
        }
        public double salary
        {
            get;
            set;
        }
        public void ShowData()
        {
            Console.WriteLine("ID-> {0}, NAME-> {1}, SALARY-> {2}", id, name, salary);
        }

       
        

     }
}
