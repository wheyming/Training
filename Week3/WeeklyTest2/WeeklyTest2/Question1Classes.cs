using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyTest2
{
    class Rectangle
    {
        public double length { get; set; }
        public double breath { get; set; }
    }

    class LandCalculator: Rectangle
    {
        public double cost { get; set; }

        public double finalCost()
        {
            double TotalCost = length * breath * cost;
            return TotalCost;
        }
    }
}
