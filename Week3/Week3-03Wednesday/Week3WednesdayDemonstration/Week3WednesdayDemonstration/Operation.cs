using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3WednesdayDemonstration
{
    // this class should not know about addition or subtraction
    static class Operation
    {
        public static void performOperation(int a, int b, delexample del)
        {
            del(a, b);
        }
    }
}
