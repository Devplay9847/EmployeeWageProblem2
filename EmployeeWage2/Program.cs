using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Parttime = 1;
            int Fulltime = 2;
            int EmpRatePERHR = 20;
            int Emphr = 0;
            int Empwage = 0;
            Random random = new Random();
            int RandomCheck = random.Next(0, 2);
            switch (RandomCheck)
            {
                case 1:
                    Emphr = 4;
                    break;
                    case 2:
                    Emphr = 8;
                    break;
                    default:
                    Emphr = 0;
                    break;
            }
            Empwage = Emphr * EmpRatePERHR;
            Console.WriteLine("EMP wage :" + Empwage);
            Console.ReadLine();
        }
    }
}
   
