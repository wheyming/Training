using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            AdditionEvent add = new AdditionEvent();
            //objname.eventma,e
            add.addCompletedEvent += Add_addCompletedEvent;
            add.performAddEvent += Add_performAddEvent;
            add.eventexample += Add_eventexample

            add.Add(3, 4);
            Console.ReadLine();
            



        }

        private static void Add_eventExample(object sender, EventArgs e)
        {
            var parent = sender.GetType();
            Console.WriteLine($"Got event from {parent} class");
        }


        private static void Add_performAddEvent(int a, int b)
        {
            Console.WriteLine("Execution completed in addition class and result is " + (a + b));
        }

        private static void Add_addCompletedEvent(int res)
        {
            Console.WriteLine("Execution completed in addition class and result is " + res);
        }
    }
}
