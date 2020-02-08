using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace file_management
{
    class Program
    {
        static void Main(string[] args)
        {
            //DirectoryInfo dir = new DirectoryInfo("C:\\Dhoni");
            //dir.Create();

            //FileInfo file = new FileInfo(@"C:\Dhoni\sample.txt");
            //file.Create();

            FileStream fs = new FileStream(@"C:\Dhoni\sample.txt", FileMode.Append, FileAccess.Write);

            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("this text has been written to the file using file i/o management very important");

            sw.Close();
            fs.Close();

            Console.WriteLine("Some content is written");

            fs = new FileStream(@"C:\Dhoni\sample.txt", FileMode.OpenOrCreate, FileAccess.Read);

            StreamReader sr = new StreamReader(fs);
            Console.WriteLine("the content is {0}", sr.ReadLine());

            
            string lineByLine;
            while ((lineByLine = sr.ReadLine()) != null)
            {
                Console.WriteLine("the string is {0}", lineByLine);

            }
        }
    }
}
