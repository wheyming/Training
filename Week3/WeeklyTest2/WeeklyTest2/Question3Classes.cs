using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyTest2
{
    interface Classes
    {
        double costperkilo { get; set; }

        double totalcost(double input);

    }


    class Firstclass : Classes
    {
        public double costperkilo
        {
            get => costperkilo;
            set => costperkilo = 0.100;
        }

        public double totalcost(double input)
        {
            return (input * costperkilo);
        }
    }

    class Secondclass : Classes
    {
        public double costperkilo
        {
            get => costperkilo;
            set => costperkilo = 0.250;
        }

        public double totalcost(double input)
        {
            return (input * costperkilo);
        }
    }

    class Thirdclass : Classes
    {
        public double costperkilo 
        { 
            get => costperkilo;
            set => costperkilo = 0.500; 
        }

        public double totalcost(double input)
        {
            return (input * costperkilo);
        }
    }
}
