using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4WednesdayPractice
{
    class CalculatorEventArgs : EventArgs
    {
        public CalculatorEventArgs(double number1, double number2, int number3)
        {
            CalculatedValue = number1 * number2 * number3;
        }

        public double CalculatedValue { get; set; }
    }

    class SimpleInterestCalculator
    {
        public EventHandler<CalculatorEventArgs> NotifyCalculate;

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
            CalculatorEventArgs calargs = new CalculatorEventArgs(Principal, Interest, Months);

            if (NotifyCalculate != null)
            {
                NotifyCalculate(this, calargs);
            }
        }

        public static void SIC_NotifyCalculate(object sender, CalculatorEventArgs tempEventArgs)
        {
            Console.WriteLine("The total simple interest is: {0}", tempEventArgs.CalculatedValue);
        }

    }

    class Program
    {        

        static void Main(string[] args)
        {
            Action<int> action1 = (a) => { Console.WriteLine("Sqrt of {0} is {1}", a, Math.Sqrt(a)); };

            Func<int, double> func1 = (a) =>
            {
                return Math.Sqrt(a);
            };

            Predicate<int> predicate1 = (a) =>
            {
                if (Math.Sqrt(a) == 10)
                {
                    return true;
                }
                return false;
            };

            action1(100);
            Console.WriteLine("Sqrt of {0} is {1}.", 100, func1(100));
            Console.WriteLine(predicate1(100));

            Console.ReadLine();

            SimpleInterestCalculator SIC = new SimpleInterestCalculator();
            SIC.NotifyCalculate += SimpleInterestCalculator.SIC_NotifyCalculate;

            SIC.getPrincipal();
            SIC.getInterest();
            SIC.getMonths();
            SIC.simpleInterestCalculate();

            Console.ReadLine();
        }
    }
}
