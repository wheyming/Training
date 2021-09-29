using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetEvents
{
    public delegate void someDelegate(int a);

    class Program
    {
        static void Main(string[] args)
        {

            Publisher p = new Publisher();
            p.numberModifiedEvent += P_numberModifiedEvent;
            p.doSomething(5);
            Console.ReadLine();
        }

        private static void P_numberModifiedEvent(object sender, IntEventArgs tempEventArg)
        {
            Console.WriteLine($"Modified data is: {tempEventArg.someIntProperty}");
        }
    }
}

