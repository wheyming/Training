using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func_Action_Predicate_Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            //Func_Examples();

            //Action_Examples();

            Predicate_Examples();
        }

        public static void Predicate_Examples()
        {
            Predicate<string> predicate = (str) =>
            {
                if (str.Length > 10)
                {
                    return true;
                }
                return false;
            };
            Predicate<int> predicate1 = (a) =>
            {
                if (a < 10)
                {
                    return true;
                }
                return false;
            };

            Console.WriteLine(predicate("str"));
            Console.WriteLine(predicate("Thisisstringstr"));
            Console.WriteLine(predicate1(9));

            Console.WriteLine();
        }
        public static void Action_Examples()
        {
            Action action = () => { Console.WriteLine("This is an empty action"); };
            Action<int, int> action1 = (a, b) => { Console.WriteLine("Product of a and b is : {0}", a * b); };
            Action<double, double> action2 = (a, b) => { Console.WriteLine("Product of a and b is : {0}", a * b); };

            action();
            action1(10, 20);
            action2(10.5, 11.9);

            Console.ReadLine();
        }
        public static void Func_Examples()
        {
            Func<int, int, int> func = sum;
            Func<int> func1 = returnConstantValue;
            Func<int, int> func2 = (a) => { return a + 100; };
            Func<int, bool> isNegative = (a) =>
            {
                if (a < 0)
                {
                    return true;
                }
                return false; // do not need else because if return true is executed the rest will not execute.
            };

            Console.WriteLine(func(10, 20));
            Console.WriteLine(func1());
            Console.WriteLine(func2(10));
            Console.WriteLine(isNegative(10));
            Console.WriteLine(isNegative(-10));

            Console.ReadLine();
        }

        public static int sum(int a, int b)
        {
            return a + b;
        }

        public static int returnConstantValue()
        {
            return 100;
        }
    }



}
