using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Practice
{
    interface CalculatorInterface
    {
        double addition(int a, int b);
        double subtraction(int a, int b);
        double multiplication(int a, int b);
        double division(int a, int b);

    }

    class Calculate : CalculatorInterface
    {
        public double addition(int a, int b)
        {
            return a + b;
        }

        public double subtraction(int a, int b)
        {
            return a - b;
        }

        public double multiplication(int a, int b)
        {
            return a * b;
        }

        public double division(int a, int b)
        {
            return a / b;
        }
    }
}
