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

            //UC-4- Switch case

            switch (employeeInput)
            {
                case FULL_TIME:
                    Console.WriteLine("Employee is fulltime");
                    empHrs = 8;
                    break;
                case PART_TIME:
                    Console.WriteLine("Employee is parttime");
                    empHrs = 4;
                    break;
                default:
                    Console.WriteLine("Employee is absent");
                    break;
            }
            //UC-2 Daily wage calculation

            empWage = EMP_RATE_PER_HR * empHrs;
            Console.WriteLine("Employee Wage is:" + empWage);

        }
    } 
}

