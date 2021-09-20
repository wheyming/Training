using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyTest2
{
    class Line
    {
        public int x1 { get; set; }
        public int x2 { get; set; }
        public int y1 { get; set; }
        public int y2 { get; set; }

        public void display()
        {
            Console.WriteLine($"\nThe start point is: ({x1} , {y1})");
            Console.WriteLine($"The end point is({x2} , {y2})");
        }

        public float slope()
        {
            float slope = ( (y1 - y2) / (x1 - x2) );
            return slope;
        }
    }
}
