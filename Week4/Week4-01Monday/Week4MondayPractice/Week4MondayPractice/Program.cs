using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4MondayPractice
{
    public delegate void CalculateSimpleInterest();

    class SimpleInterestCalculator
    {
        public delegate void Sender(double simpleinterest);
        public event Sender NotifyCalculate;

        private double Principal;
        private double Interest;
        private int Months;

        public void getPrincipal()
        {
            Console.WriteLine("Please input Principal Value: ");
            Principal = Convert.ToDouble(Console.ReadLine());
        }
        public void getInterest()
        {
            Console.WriteLine("Please input Interest Value: ");
            Interest = Convert.ToDouble(Console.ReadLine());
        }
        public void getMonths()
        {
            Console.WriteLine("Please input number of Months: ");
            Months = Int32.Parse(Console.ReadLine());
        }
        public void simpleInterestCalculate()
        {
            double SIC = (Principal * Interest * Months) / 100;
            NotifyCalculate.Invoke(SIC);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            SimpleInterestCalculator SIC = new SimpleInterestCalculator();
            CalculateSimpleInterest CalSIC = new CalculateSimpleInterest(SIC.getPrincipal);
            CalSIC += SIC.getInterest;
            CalSIC += SIC.getMonths;
            CalSIC += SIC.simpleInterestCalculate;
            SIC.NotifyCalculate += SIC_NotifyCalculate;

            CalSIC();
            Console.ReadLine();

        }

        private static void SIC_NotifyCalculate(double simpleinterest)
        {
            Console.WriteLine(simpleinterest);
        }
    }
}
