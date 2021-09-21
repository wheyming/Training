using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class CalculatorClass
    {
        public int x;
        public int y;
        static int total = 0;

        public int addition()
        {
            Counter();
            return x + y;
        }

        public int subtraction()
        {
            Counter();
            return x - y;
        }

        public int Counter()
        {
            return total = total + 1;
        }
    }
}
