using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empwagecalculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to employeewage calculation");
            //Attendace (present or absent) 
            int PRESENT = 1;

            Random random = new Random();
            int ATTENDANCE = random.Next(0, 2);

            if (ATTENDANCE == PRESENT)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                Console.ReadLine();
            }
        }
    }
}
