using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4TuesdayDemonstration
{

    delegate void del(int p, double k, ref )

    class Program
    {
        static void Main(string[] args)
        {
            a tempa = new a();
            int s = 0;

            Console.WriteLine("Value of s before delegate call " + s);
            del tempdel = new del(ref tempa.x);
            tempdel(4, 4, 7, ref s, out int i);
            Console.WriteLine("Value of s after delegate call " + s);
            Console.WriteLine("Value of t " + t);
            Console.ReadLine();

        }
    }
}
