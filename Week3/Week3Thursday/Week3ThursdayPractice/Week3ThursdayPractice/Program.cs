using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Week3ThursdayPractice
{

    class Program
    {    
        static void Main(string[] args)
        {
            Counter C = new Counter();
            C.EventRaised += OnCount5Complete;
            C.increaseCount();
            Console.ReadLine();
        }

        public static void OnCount5Complete()
        {
            Console.WriteLine("Event Received");
        }
    }
}
