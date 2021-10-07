using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Week5TuesdayPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int y;
            for(; ; )
            {
                Methods Q1 = new Methods();
                Q1.callingMethod(out y);
                Thread borrowBookp = new Thread(Q1.borrowBook);
                borrowBookp.Start(y);
            }                

        }
    }
}
