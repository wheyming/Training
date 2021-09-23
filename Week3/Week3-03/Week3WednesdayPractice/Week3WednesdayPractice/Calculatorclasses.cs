using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3WednesdayPractice
{
    public delegate int Calculation(int x, int y);

    class Calculatorclasses
    {

        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Sub(int x, int y)
        {
            return x - y;
        }
    }
}
