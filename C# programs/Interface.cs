using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @interface
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] marks = new int[6] { 85, 87, 89, 84, 85, 90 };

            Result objR = new Result();
            var avg = objR.Getaveragemarks(marks);
            objR.Displayaverage(avg);
            objR.Showgrade(avg);

        }

    }
    public interface IExam
    {
        double Getaveragemarks(int[] marks);
        void Displayaverage(double avg);
    }
    public interface IStudent
    {
        void Showgrade(double avg);
    }
    public class Result  : IExam, IStudent
    {
        public void Displayaverage(double avg)
        {
            Console.WriteLine("the average marks = {0}", avg);
        }
        public double Getaveragemarks(int[] marks)
        {
            int total;
            double avg;
            total = 0;
            for (int i = 1; i < marks.Length; i++)
                total += marks[i];
            avg = total / marks.Length;
            return avg;
        }
        public void Showgrade(double avg)
        {
            if (avg >= 70.00)
                Console.WriteLine("passed in distinction");
            else
                Console.WriteLine("not a distinction");
        }

       
    }

}
