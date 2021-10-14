using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestDemo
{
    class CalculatorManagement
    {
        private ICalculator calc;
        public int addResult, subResult, mulResult, divResult;

        public CalculatorManagement(ICalculator calculator)
        {
            calc = calculator;
        }

        public void CallCalculatorMethod(int a, int b)
        {
            addResult = calc.Addition(a, b);
            Console.WriteLine("Addition: " + addResult);
            subResult = calc.Subtract(a, b);
            Console.WriteLine("Subtract: " + subResult);
            mulResult = calc.Multiply(a, b);
            Console.WriteLine("Multiply: " + mulResult);
            divResult = calc.Divide(a, b);
            Console.WriteLine("Divide: " + divResult);
        }
    }
}
