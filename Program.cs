using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empwagecalculation
{
    internal class Program
    {
        public const int FullTime = 1;
        public const int PartTime = 2;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee wage calculation\n");
            // UC-8 Empwage for multiple companies
            GetEmpWage("TCS", 20, 22, 60);
            GetEmpWage("Infosys", 25, 24, 70);
            GetEmpWage("CTS", 20, 26, 60);

            Console.ReadLine();
        }
        public static void GetEmpWage(string companyname, int emprateperhr, int Maxworkigdays, int Maxworkighrs)
        {
            int empwage = 0, totalwage = 0, Emphrs = 0, TotalHrs = 0, day = 1;
            //UC-1 employee is present or absent
            Random random = new Random();
            //UC-6 Empwage for max working days & for max working hrs
            while(day<=Maxworkigdays && TotalHrs <= Maxworkighrs  )
            {
                int employeinput = random.Next(0, 3);
                //UC-4 Switch case
                switch (employeinput)
                {
                    case FullTime:
                        Emphrs = 8;
                        break;
                    case PartTime:
                        Emphrs = 4;
                        break;
                    default:
                        Emphrs = 0;
                        break;
                }
                //UC-2 Total wage 
                empwage = emprateperhr * Emphrs;
                totalwage += empwage;
                TotalHrs += Emphrs;
                day++;
                }
            Console.WriteLine("{0}: Total wage for{1} days :{2} and Hrs:{3}", companyname, (day - 1), totalwage, (TotalHrs - Emphrs));

            }

        }
    }
   

