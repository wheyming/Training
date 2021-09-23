using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3WednesdayDemonstration
{
    delegate void delexample(int i, int j);
    delegate void displaydel();

    class Addition
    {
        public void Add(int a, int b)
        {
            Console.WriteLine("In Sample Addition: " + (a + b));

        }

        public static void print()
        {
            Console.WriteLine("In Sample Addition static: ");
        }

        public void print1()
        {
            Console.WriteLine("In Sample Addition static1: ");
        }

    }
    class Subtract
    {       
        public void Sub(int a, int b)
        {
            Console.WriteLine("In Sample Subtraction: " +  (a - b));
        }

    }
    class Multiply
    {
        public void Mul(int a, int b)
        {
            Console.WriteLine("In Sample Multiplication: " + (a * b));
        }
    }

}
