using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] employees = new string[6] { "kowshik", "gokul", "praveen", "venu", "kartheek", "milan" };
            //var knownemp = from emp in employees
            //where emp.Contains("k")
            //select emp;
            var someempls = employees.Where(s => s.Contains("k"));

            foreach (var emp in someempls)
            {
                Console.WriteLine("empname contains k : {0}", emp);
            }
            Console.WriteLine("*********************************");
            List<string> fruits = new List<string>() { "apple", "orange", "grapes", "pineapple", "banana", "watermelon" };

            var fruitsP = from p in fruits
                          where p.Contains("e")
                          select p;

            foreach (var pp in fruitsP)
            {
                Console.WriteLine("fruitsP contains e:{0}", pp);
            }
            Console.WriteLine("---------------------------------");
            var flength = from length in fruits
                          where length.Length >= 4
                          select length;
            foreach (var kk in flength)
            {
                Console.WriteLine("flength greater than 4: {0}", kk);


            }
            Console.WriteLine("---------------------------------");

            int[] marks = new int[6] { 99, 98, 97, 96, 94, 95 };

            var highm = from m in marks
                        where m > 90
                        select m;

            foreach (var m in highm)
            {
                Console.WriteLine("high marks : {0}", m);
            }
            Console.WriteLine("//////////////////////");

            var marksinorder = from m in marks
                               orderby m
                               select m;

            foreach (var m in marksinorder)
            {
                Console.WriteLine("ordered marks : {0}", m);
            }
            var marksdescending = marks.OrderByDescending(m => m);
            foreach (var m in marksinorder)
            {
                Console.WriteLine("descending marks : {0}", m);
            }
            Console.WriteLine("//////////////////////");

            List<employee> empe = new List<employee>();
            empe.Add(new employee() { name = "gokul", empid = 101 });
            empe.Add(new employee() { name = "kowshik", empid = 102 });
            empe.Add(new employee() { name = "jagan", empid = 103 });

            var empl = from em in empe
                       where em.name.Contains("k")
                       select em;


            foreach (var em in empl)
            {
                Console.WriteLine("name :{0}, empid: {1}", em.name, em.empid);
            }
            Console.WriteLine("---------------------------------");


            //product class
            List<product> pro = new List<product>();
            pro.Add(new product() { pname = "bentley", pid = 1001 });
            pro.Add(new product() { pname = "audi", pid = 4002 });
            pro.Add(new product() { pname = "lamborghini", pid = 3003 });
            pro.Add(new product() { pname = "mercedes", pid = 2004 });



            var pdetails = from p in pro
                           where p.pname.Contains("e")
                           select p;

            foreach (var ppp in pdetails)
            {
                Console.WriteLine("name : {0}, pid :::: {1}", ppp.pname, ppp.pid);
            }



            //product class

            Console.WriteLine("---------------------------------");

            List<teacher> teachers = new List<teacher>
            {
            new teacher { firstname = "bentley", lastname = "gokul", city = "Germany", id = 1001 },
            new teacher { firstname = "audi", lastname = "praveen", city = "Texas", id = 4002 },
            new teacher { firstname = "lamborghini", lastname = "kowshik", city = "London", id = 3003 },
            new teacher { firstname = "mercedes", lastname = "venu", city = "Delhi", id = 2004 }
            };


            List<student> students = new List<student>
            {
            new student { firstname = "kiran", lastname = "rathode", city = "Germany", id = 1009 },
            new student { firstname = "adharva", lastname = "trivedi", city = "Texas", id = 4008 },
            new student { firstname = "virat", lastname = "kohli", city = "London", id = 3001 },
            new student { firstname = "aswin", lastname = "ravichandran", city = "Delhi", id = 2009 }
            };


            var peopleintexas = (from tea in teachers
                                 where tea.city == "Germany"
                                 select tea.firstname)
                                 .Concat(from stu in students
                                         where stu.city == "Germany"
                                         select stu.firstname);

            foreach(var person in peopleintexas)
            {
                Console.WriteLine("from texas city: {0}", person);
            }

        }
        public class employee
        {
            public string name { get; set; }
            public int empid { get; set; }

        }
        public class product
        {
            public string pname { get; set; }
            public int pid { get; set; }
        }

        public class teacher
        {
            public string firstname { get; set; }
            public string lastname { get; set; }
            public string city { get; set; }
            public int id { get; set; }
        }

        public class student
        {
            public string firstname { get; set; }
            public string lastname { get; set; }
            public string city { get; set; }
            public int id { get; set; }
        }
    }
}
