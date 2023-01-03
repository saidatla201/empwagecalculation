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
            const int MAX_WORKING_DAYS = 20;
            const int Max_WORKING_HRS = 100;
            int empHrs = 0, empWage = 0, totalWage = 0, day = 1, totalhrs = 0;

            //UC-1 Attendance
            Random random = new Random();
            //UC-6
            while ( day <= MAX_WORKING_DAYS && totalhrs <= Max_WORKING_HRS  )

            {
                int employeeInput = random.Next(0, 3);
                //UC-4- Switch case
                switch (employeeInput)
                {
                    case FULL_TIME:
                        empHrs = 8;
                        break;
                    case PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                //UC-2 dailywise calculation
                empWage = EMP_RATE_PER_HR * empHrs;
                totalWage += empWage;
                totalhrs += empHrs;
                day++;
            }
            Console.WriteLine("Total wage for {0} days:{1} and Hrs: {2}", (day - 1), totalWage,(totalhrs -empHrs ));
            Console.ReadLine();
        }
    } 
}

