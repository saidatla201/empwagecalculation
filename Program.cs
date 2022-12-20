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
            Console.WriteLine("Welcome to EmplyeeWageCompute");
            const int FULL_TIME = 1;
            const int PART_TIME = 2;
            const int EMP_RATE_PER_HR = 20;
            int empHrs = 0, empWage = 0;

            //UC-1 Attendance
            Random random = new Random();
            int employeeInput = random.Next(0, 3);

            if (FULL_TIME == employeeInput)
            {
                Console.WriteLine("Employee is fulltime");
                empHrs = 8;
            }
            else if (PART_TIME == employeeInput)
            {
                Console.WriteLine("Employee is parttime");
                empHrs = 4;
            }
            else
            {
                Console.WriteLine("Employee is absent");
                empHrs = 0;
            }

            //UC-2 Dailywage 
            empWage = EMP_RATE_PER_HR * empHrs;
            Console.WriteLine("Employee Wage is:" + empWage);
        }

    }  
}
