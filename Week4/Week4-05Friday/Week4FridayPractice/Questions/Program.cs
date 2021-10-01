using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Questions
{
    class Calculation
    {
        double input { get; set; }
        static double input2;
        static double total = 0;
        int i;

        public void Input()
        {
            input = Convert.ToDouble(Console.ReadLine());
        }

        public void Calculate()
        {
            for (i = 0; ; i++)
            {
                Thread.Sleep(900);
                if (i < 6)
                {
                    input2 = input * 0.8;
                }
                else input2 = input;

                total = total + input2 - CalculateTax() - CalculatePF() - CalculateHI() - CalculateMF();
            }
        }

        double CalculateTax()
        {
            double tax = input2 * 0.12;
            return tax;
        }

        double CalculatePF()
        {
            double PF = input2 * 0.08;
            return PF;
        }
        double CalculateHI()
        {
            double HI = input2 * 0.05;
            return HI;
        }

        double CalculateMF()
        {
            double MF = input2 * 0.07;
            return MF;
        }

        public void ReportTotalEarned()
        {
            for (i = 0; ;)
            {
                Thread.Sleep(1000);
                Console.WriteLine("Current Salary is {0}, Total Earnings is {1}.", input2, total);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            // Q1
            Calculation C = new Calculation();
            Thread Reportvalue = new Thread(C.ReportTotalEarned);
            C.Input();
            Reportvalue.Start();
            C.Calculate();
            Console.ReadLine();


            //Q2
            Question2 Q2 = new Question2();
            Thread Q2add = new Thread(Q2.addNumbers);
            Q2.getInput();
            Q2add.Start();
            Thread.Sleep(100);
            Q2.printnumbers();
            Q2add.Abort();
            Console.ReadLine();

            
            //Q3


        }
    }
}
